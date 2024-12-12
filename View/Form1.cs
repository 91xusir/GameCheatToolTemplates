using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TbBaiZhouKeJi.View;

namespace TbBaiZhouKeJi
{
    public partial class Form1 : Form
    {
        //private const int maxCheckboxCount = 24;
        private Dictionary<int, string> checkboxMap = new Dictionary<int, string>()
{
    { 1, "卡牌无冷却" },
    { 2, "无条件种植" },
    { 3, "手套无冷却" },
    { 4, "全屏秒杀" },
    { 5, "大嘴花增强" },
};

        public Dictionary<int, AntdUI.Checkbox> checkboxList = new Dictionary<int, AntdUI.Checkbox>();
        private Form FatherForm;
        public Form1(FormMain fatherForm)
        {
            FatherForm = fatherForm;
            InitializeComponent();
            CheckboxMapInit();
            // 订阅主窗体的热键事件
            fatherForm.HotkeyPressed += OnHotkeyPressed;
        }
        private void OnHotkeyPressed(int hotkeyId)
        {
            // 处理热键按下的逻辑 1-9 alt 21-29 ctrl 11-19
            if (checkboxMap.ContainsKey(hotkeyId))
                if (checkboxList[hotkeyId].Enabled)
                    checkboxList[hotkeyId].Checked = !checkboxList[hotkeyId].Checked;

        }

        private void CheckboxMapInit()
        {
            /*  AntdUI.TooltipComponent tooltip = new AntdUI.TooltipComponent()
              {
                  Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
              };
              tooltip.ArrowAlign = AntdUI.TAlign.Bottom;*/

            for (int i = checkboxMap.Count; i >= 1; i--)
            {
                var checkbox = new AntdUI.Checkbox();
                checkbox.AutoSizeMode = AntdUI.TAutoSize.Auto;
                checkbox.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
                checkbox.Font = new System.Drawing.Font("微软雅黑", 11F);
                checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                checkbox.Location = new System.Drawing.Point(3, 3);
                checkbox.Name = $"{checkboxMap[i]} [数字键{i}]";
                checkbox.Size = new System.Drawing.Size(220, 52);
                checkbox.TabIndex = 3;
                checkbox.Tag = i.ToString();
                checkbox.Text = checkbox.Name;
                checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                checkbox.CheckedChanged += new AntdUI.BoolEventHandler(this.Checkbox_CheckedChanged);
                this.flowPanel1.Controls.Add(checkbox);
                checkboxList.Add(i, checkbox);
                //tooltip.SetTip(checkbox, "prompt text");
            }
        }

        private void Checkbox_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            AntdUI.Checkbox checkbox = sender as AntdUI.Checkbox;
            if (FormMain.IsGameOpen)//游戏打开了
            {
                bool isOpenSuccess = false;
                Console.WriteLine(checkbox.Tag + " " + e.Value);
                switch (checkbox.Tag)
                {
                    case "1":
                        isOpenSuccess = Service1.Cheat1(e.Value);
                        break;
                    case "2":
                        isOpenSuccess = Service1.Cheat2(e.Value);
                        break;
                    case "3":
                        isOpenSuccess = Service1.Cheat3(e.Value);
                        break;
                    case "4":
                        isOpenSuccess = Service1.Cheat4(e.Value);
                        break;
                    case "5":
                        isOpenSuccess = Service1.Cheat5(e.Value);
                        break;
                }
                if (!isOpenSuccess)//激活失败
                {
                    AntdUI.Message.warn(FatherForm, "该功能激活失败，请联系作者修复！", autoClose: 5);
                    checkbox.Enabled = false;//禁用
                    return;
                }
                if (e.Value == true)
                {
                    FormGeneral.startSound.Play();
                }
                else
                    FormGeneral.stopSound.Play();
            }
            else
            { //游戏没有打开
                if (checkbox.Checked)
                    AntdUI.Message.warn(FatherForm, "请先启动游戏！", autoClose: 3);
                checkbox.Checked = false;
                return;
            }
        }
        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            DllImport.ReleaseCapture();
            DllImport.SendMessage(FatherForm.Handle, 0x0112, 0xF012, 0);
        }
    }
}
