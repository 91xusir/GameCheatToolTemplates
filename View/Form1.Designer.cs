namespace TbBaiZhouKeJi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowPanel1 = new AntdUI.FlowPanel();
            this.SuspendLayout();
            // 
            // flowPanel1
            // 
            this.flowPanel1.Align = AntdUI.TAlignFlow.Left;
            this.flowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowPanel1.Name = "flowPanel1";
            this.flowPanel1.Size = new System.Drawing.Size(716, 462);
            this.flowPanel1.TabIndex = 4;
            this.flowPanel1.Text = "flowPanel1";
            this.flowPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(716, 462);
            this.Controls.Add(this.flowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.FlowPanel flowPanel1;
    }
}