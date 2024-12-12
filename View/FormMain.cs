using Gma.System.MouseKeyHook;
using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TbBaiZhouKeJi
{
    public partial class FormMain : Form
    {
        // 定义热键事件，传递热键 ID
        public event Action<int> HotkeyPressed;
        private IKeyboardMouseEvents m_GlobalHook;


        public static bool IsGameOpen = false; // 是否打开目标进程
        private Dictionary<string, Form> formMap;
        private Form NowSelectForm;


        public FormMain()
        {
         
            ApplyFadeIn(this);
            InitializeComponent();
            AntUIConfigInit();//主题设置
            ChildenFormInit();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuMainInit();
            StartUIHide();
            DllImport.AllocConsole();
            Task.Run(() => ProcessCheck());
            Subscribe();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegisterHotKeyTool.UnregisterAllHotKeys(this);
            Unsubscribe();
            CloseAllFunction();
        }

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KeyPress: \t{0}", e.KeyChar);
        }

        public void Unsubscribe()
        {
            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            m_GlobalHook.Dispose();
        }

        private void CloseAllFunction()
        {
            // 获取 Service1 类型
            Type serviceType = typeof(Service1);

            // 创建 Service1 的实例
            object serviceInstance = Activator.CreateInstance(serviceType);

            // 遍历所有方法
            foreach (MethodInfo method in serviceType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                // 确保方法的参数数量为 1 且参数类型为 bool
                ParameterInfo[] parameters = method.GetParameters();
                if (parameters.Length == 1 && parameters[0].ParameterType == typeof(bool))
                {
                    try
                    {
                        // 调用方法，传递参数 false
                        object result = method.Invoke(serviceInstance, new object[] { false });
                        Console.WriteLine($"方法 {method.Name} 执行成功，返回值：{result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"调用方法 {method.Name} 时出错：{ex.Message}");
                    }
                }
            }
        }

        private void ChildenFormInit()
        {
            formMap = new Dictionary<string, Form>
            {
                { "1", new Form1(this) },
                { "2", new Form2() },
                { "3", new Form3() }
            };
            foreach (var childForm in formMap)
            {
                childForm.Value.TopLevel = false;
                childForm.Value.Parent = this.stackPanelChildForm;
                childForm.Value.Dock = DockStyle.Fill;
                childForm.Value.ClientSize = this.stackPanelChildForm.ClientSize;
                childForm.Value.Hide();
                childForm.Value.MouseDown += new System.Windows.Forms.MouseEventHandler(Move_MouseDown);

            }
        }
        private void AntUIConfigInit()
        {
            AntdUI.Config.IsDark = true;
            AntdUI.Config.ShowInWindow = true;
            AntdUI.Config.Font = new Font("微软雅黑", 10);
            //AntdUI.Config.Animation = false;//关闭动画
        }
        private void MenuMainInit()
        {
            this.menuMain.SelectIndex(0);
            foreach (var item in menuMain.Items)
            {
                item.Visible = false;
            }
            for (int i = 0; i < formMap.Count; i++)
            {
                menuMain.Items[i].Visible = true;
            }
        }

        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            DllImport.ReleaseCapture();
            DllImport.SendMessage(this.Handle, 0x0112, 0xF012, 0);
        }

        private void MenuMain_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {
            var id = e.Value.ID;
            if (formMap[id].Equals(NowSelectForm)) return;
            if (NowSelectForm != null) NowSelectForm.Hide();
            formMap[id].Show();
            NowSelectForm = formMap[id];
        }

        private void linkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("IExplore", "http://www.baidu.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("IExplore", "https://s.threatbook.com/report/file/a57131826417972d0dc32dbe0209c1d8533d5ac7616771fff307fa6b7604ce11");

        }
        // 实时检查目标进程是否重新启动
        private async Task ProcessCheck()
        {
            while (true)
            {
                Console.WriteLine($"正在监测{AppConfig.FILE_NAME}进程是否启动...");
                Process[] processes = Process.GetProcessesByName(AppConfig.FILE_NAME);
                if (processes.Length > 0)
                {
                    UnlockThis();//解锁修改器
                    Process targetProcess = processes[0];
                    targetProcess.EnableRaisingEvents = true;
                    targetProcess.Exited += (sender, e) =>
                    {
                        LockThis();//锁定修改器
                        Task.Run(() => ProcessCheck());
                    };

                    break;
                }
                await Task.Delay(1000);  // 非阻塞的延迟 1 秒
            }
        }

        private void StartUIShow()
        {
            this.labGameStop.Hide();
            this.labGameStart.Show();
        }
        private void StartUIHide()
        {
            this.labGameStart.Hide();
            this.labGameStop.Show();
        }

        private void UnlockThis()
        {
            Service1.MemLib.OpenProcess(AppConfig.FILE_NAME);
            StartUIShow();
            Console.WriteLine($"{AppConfig.FILE_NAME} 已启动.");
            IsGameOpen = true;
        }
        private void LockThis()
        {
            IsGameOpen = false;
            StartUIHide();
        }
        public static void ApplyFadeIn(Form form, double fadeInInterval = 0.05, int timerInterval = 20)
        {
            form.Opacity = 0;
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = timerInterval; // 每 50 毫秒触发一次
            fadeInTimer.Tick += (sender, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += fadeInInterval; // 每次增加一定量的透明度
                }
                else
                {
                    fadeInTimer.Stop();
                }
            };
            fadeInTimer.Start();
        }
    }
}
