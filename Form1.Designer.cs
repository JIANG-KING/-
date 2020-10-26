namespace 鼠标指针
{
    partial class Form1
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
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(94, 43);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(202, 15);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "如果你点到它，游戏就结束了";
            // 
            // btnMe
            // 
            this.btnMe.Location = new System.Drawing.Point(0, 0);
            this.btnMe.Name = "btnMe";
            this.btnMe.Size = new System.Drawing.Size(176, 25);
            this.btnMe.TabIndex = 1;
            this.btnMe.Text = "你点得到吗？";
            this.btnMe.UseVisualStyleBackColor = true;
            this.btnMe.Click += new System.EventHandler(this.btnMe_Click);
            this.btnMe.MouseCaptureChanged += new System.EventHandler(this.btnMe_MouseEnter);
            this.btnMe.MouseEnter += new System.EventHandler(this.btnMe_MouseEnter);
            this.btnMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMe_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnMe);
            this.Controls.Add(this.lbInfo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.btnMe_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnMe;
    }
}

