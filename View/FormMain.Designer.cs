using System.Drawing;

namespace TbBaiZhouKeJi
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem4 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            this.windowBar = new AntdUI.WindowBar();
            this.panelRight = new AntdUI.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.divider2 = new AntdUI.Divider();
            this.divider1 = new AntdUI.Divider();
            this.panel1 = new AntdUI.Panel();
            this.menuMain = new AntdUI.Menu();
            this.labGameStop = new AntdUI.Label();
            this.labGameStart = new AntdUI.Label();
            this.stackPanelMain = new AntdUI.StackPanel();
            this.stackPanelLeft = new AntdUI.StackPanel();
            this.stackPanelbttom = new AntdUI.StackPanel();
            this.panel2 = new AntdUI.Panel();
            this.alert1 = new AntdUI.Alert();
            this.stackPanelChildForm = new AntdUI.StackPanel();
            this.panelRight.SuspendLayout();
            this.stackPanelMain.SuspendLayout();
            this.stackPanelLeft.SuspendLayout();
            this.stackPanelbttom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowBar
            // 
            this.windowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.windowBar.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.windowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowBar.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar.ForeColor = System.Drawing.Color.White;
            this.windowBar.IconSvg = resources.GetString("windowBar.IconSvg");
            this.windowBar.Location = new System.Drawing.Point(0, 0);
            this.windowBar.MaximizeBox = false;
            this.windowBar.Mode = AntdUI.TAMode.Dark;
            this.windowBar.Name = "windowBar";
            this.windowBar.Size = new System.Drawing.Size(888, 30);
            this.windowBar.SubText = "QQ:806406129";
            this.windowBar.TabIndex = 3;
            this.windowBar.Text = " xxx修改器        ";
            // 
            // panelRight
            // 
            this.panelRight.Back = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelRight.Controls.Add(this.linkLabel3);
            this.panelRight.Controls.Add(this.linkLabel2);
            this.panelRight.Controls.Add(this.linkLabel1);
            this.panelRight.Controls.Add(this.linkUpdate);
            this.panelRight.Controls.Add(this.divider2);
            this.panelRight.Controls.Add(this.divider1);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.menuMain);
            this.panelRight.Location = new System.Drawing.Point(3, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Radius = 5;
            this.panelRight.Size = new System.Drawing.Size(154, 507);
            this.panelRight.TabIndex = 0;
            this.panelRight.Text = "panelRight";
            this.panelRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkLabel3.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel3.Location = new System.Drawing.Point(36, 471);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(66, 20);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "广告位...";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(36, 400);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 20);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "查毒报告";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(36, 435);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "广告位...";
            // 
            // linkUpdate
            // 
            this.linkUpdate.AutoSize = true;
            this.linkUpdate.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkUpdate.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkUpdate.Location = new System.Drawing.Point(36, 363);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(69, 20);
            this.linkUpdate.TabIndex = 6;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Text = "检查更新";
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdate_LinkClicked);
            // 
            // divider2
            // 
            this.divider2.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(186)))));
            this.divider2.Location = new System.Drawing.Point(0, 338);
            this.divider2.Name = "divider2";
            this.divider2.OrientationMargin = 0F;
            this.divider2.Size = new System.Drawing.Size(154, 10);
            this.divider2.TabIndex = 5;
            this.divider2.Text = "";
            // 
            // divider1
            // 
            this.divider1.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(186)))));
            this.divider1.Location = new System.Drawing.Point(0, 158);
            this.divider1.Name = "divider1";
            this.divider1.OrientationMargin = 0F;
            this.divider1.Size = new System.Drawing.Size(154, 10);
            this.divider1.TabIndex = 4;
            this.divider1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TbBaiZhouKeJi.Properties.Resources.imgdemo;
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 8;
            this.panel1.Size = new System.Drawing.Size(146, 150);
            this.panel1.TabIndex = 5;
            this.panel1.Text = "panel1";
            // 
            // menuMain
            // 
            this.menuMain.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.menuMain.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuMain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuMain.ForeActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(160)))), ((int)(((byte)(50)))));
            this.menuMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.menuMain.IconRatio = 0.9F;
            menuItem1.IconSvg = resources.GetString("menuItem1.IconSvg");
            menuItem1.ID = "1";
            menuItem1.Select = true;
            menuItem1.Text = "常用功能";
            menuItem2.IconSvg = resources.GetString("menuItem2.IconSvg");
            menuItem2.ID = "2";
            menuItem2.Text = "高级功能";
            menuItem3.IconSvg = resources.GetString("menuItem3.IconSvg");
            menuItem3.ID = "3";
            menuItem3.Text = "个人中心";
            menuItem4.ID = "4";
            menuItem4.Text = "功能4";
            menuItem5.ID = "5";
            menuItem5.Text = "功能5";
            this.menuMain.Items.Add(menuItem1);
            this.menuMain.Items.Add(menuItem2);
            this.menuMain.Items.Add(menuItem3);
            this.menuMain.Items.Add(menuItem4);
            this.menuMain.Items.Add(menuItem5);
            this.menuMain.Location = new System.Drawing.Point(0, 183);
            this.menuMain.Name = "menuMain";
            this.menuMain.Radius = 3;
            this.menuMain.Size = new System.Drawing.Size(148, 145);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuMain";
            this.menuMain.SelectChanged += new AntdUI.SelectEventHandler(this.MenuMain_SelectChanged);
            // 
            // labGameStop
            // 
            this.labGameStop.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.labGameStop.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labGameStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.labGameStop.Location = new System.Drawing.Point(599, 11);
            this.labGameStop.Name = "labGameStop";
            this.labGameStop.PrefixSvg = resources.GetString("labGameStop.PrefixSvg");
            this.labGameStop.Size = new System.Drawing.Size(120, 22);
            this.labGameStop.TabIndex = 2;
            this.labGameStop.Text = "请先运行游戏";
            // 
            // labGameStart
            // 
            this.labGameStart.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.labGameStart.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labGameStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.labGameStart.Location = new System.Drawing.Point(599, 11);
            this.labGameStart.Name = "labGameStart";
            this.labGameStart.PrefixSvg = resources.GetString("labGameStart.PrefixSvg");
            this.labGameStart.Size = new System.Drawing.Size(89, 22);
            this.labGameStart.TabIndex = 1;
            this.labGameStart.Text = "运行成功";
            // 
            // stackPanelMain
            // 
            this.stackPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.stackPanelMain.Controls.Add(this.stackPanelLeft);
            this.stackPanelMain.Controls.Add(this.panelRight);
            this.stackPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanelMain.Location = new System.Drawing.Point(0, 30);
            this.stackPanelMain.Name = "stackPanelMain";
            this.stackPanelMain.Size = new System.Drawing.Size(888, 513);
            this.stackPanelMain.TabIndex = 4;
            this.stackPanelMain.Text = "stackPanelMain";
            this.stackPanelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            // 
            // stackPanelLeft
            // 
            this.stackPanelLeft.Controls.Add(this.stackPanelbttom);
            this.stackPanelLeft.Controls.Add(this.stackPanelChildForm);
            this.stackPanelLeft.Location = new System.Drawing.Point(163, 3);
            this.stackPanelLeft.Name = "stackPanelLeft";
            this.stackPanelLeft.Size = new System.Drawing.Size(722, 507);
            this.stackPanelLeft.TabIndex = 1;
            this.stackPanelLeft.Text = "stackPanelLeft";
            this.stackPanelLeft.Vertical = true;
            // 
            // stackPanelbttom
            // 
            this.stackPanelbttom.Controls.Add(this.panel2);
            this.stackPanelbttom.Location = new System.Drawing.Point(3, 469);
            this.stackPanelbttom.Name = "stackPanelbttom";
            this.stackPanelbttom.Size = new System.Drawing.Size(716, 41);
            this.stackPanelbttom.TabIndex = 1;
            this.stackPanelbttom.Text = "stackPanelbttom";
            // 
            // panel2
            // 
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.labGameStop);
            this.panel2.Controls.Add(this.alert1);
            this.panel2.Controls.Add(this.labGameStart);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 0;
            this.panel2.Size = new System.Drawing.Size(710, 35);
            this.panel2.TabIndex = 0;
            this.panel2.Text = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            // 
            // alert1
            // 
            this.alert1.ForeColor = System.Drawing.Color.DarkGray;
            this.alert1.Location = new System.Drawing.Point(244, 0);
            this.alert1.Loop = true;
            this.alert1.Name = "alert1";
            this.alert1.Size = new System.Drawing.Size(195, 39);
            this.alert1.TabIndex = 1;
            this.alert1.Text = "快捷键数字均为小键盘！              无毒放心使用！                  报毒建议关闭杀毒软件！";
            // 
            // stackPanelChildForm
            // 
            this.stackPanelChildForm.Location = new System.Drawing.Point(3, 3);
            this.stackPanelChildForm.Name = "stackPanelChildForm";
            this.stackPanelChildForm.Size = new System.Drawing.Size(716, 460);
            this.stackPanelChildForm.TabIndex = 0;
            this.stackPanelChildForm.Text = "stackPanelChildForm";
            this.stackPanelChildForm.Vertical = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.ControlBox = false;
            this.Controls.Add(this.stackPanelMain);
            this.Controls.Add(this.windowBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "白昼科技";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.stackPanelMain.ResumeLayout(false);
            this.stackPanelLeft.ResumeLayout(false);
            this.stackPanelbttom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.WindowBar windowBar;
        private AntdUI.Panel panelRight;
        private AntdUI.Label labGameStop;
        private AntdUI.Label labGameStart;
        private AntdUI.StackPanel stackPanelMain;
        private AntdUI.StackPanel stackPanelLeft;
        private AntdUI.Menu menuMain;
        private AntdUI.Divider divider1;
        private AntdUI.Panel panel1;
        private AntdUI.Divider divider2;
        private System.Windows.Forms.LinkLabel linkUpdate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private AntdUI.StackPanel stackPanelChildForm;
        private AntdUI.Alert alert1;
        private AntdUI.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private AntdUI.StackPanel stackPanelbttom;
    }
}

