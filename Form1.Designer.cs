namespace SrtTranlatorGUI
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.button选择文件 = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.button粘贴 = new System.Windows.Forms.Button();
            this.button复制右边 = new System.Windows.Forms.Button();
            this.button存储左边 = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "字幕文件|*.srt|所有文件|*.*";
            this.openFileDialog.Title = "选择要翻译的字幕文件";
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.AllowDrop = true;
            this.textBoxFilename.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(161, 21);
            this.textBoxFilename.TabIndex = 0;
            this.textBoxFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFilename_DragDrop);
            this.textBoxFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFilename_DragEnter);
            // 
            // button选择文件
            // 
            this.button选择文件.Location = new System.Drawing.Point(179, 10);
            this.button选择文件.Name = "button选择文件";
            this.button选择文件.Size = new System.Drawing.Size(62, 23);
            this.button选择文件.TabIndex = 1;
            this.button选择文件.Text = "选择文件";
            this.button选择文件.UseVisualStyleBackColor = true;
            this.button选择文件.Click += new System.EventHandler(this.button选择文件_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(247, 10);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(62, 23);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(451, 10);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(62, 23);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Font = new System.Drawing.Font("宋体", 7F);
            this.textBoxLeft.Location = new System.Drawing.Point(12, 40);
            this.textBoxLeft.Multiline = true;
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLeft.Size = new System.Drawing.Size(286, 312);
            this.textBoxLeft.TabIndex = 4;
            // 
            // textBoxRight
            // 
            this.textBoxRight.Font = new System.Drawing.Font("宋体", 7F);
            this.textBoxRight.Location = new System.Drawing.Point(304, 40);
            this.textBoxRight.Multiline = true;
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRight.Size = new System.Drawing.Size(271, 312);
            this.textBoxRight.TabIndex = 5;
            // 
            // button粘贴
            // 
            this.button粘贴.Location = new System.Drawing.Point(383, 10);
            this.button粘贴.Name = "button粘贴";
            this.button粘贴.Size = new System.Drawing.Size(62, 23);
            this.button粘贴.TabIndex = 6;
            this.button粘贴.Text = "粘贴";
            this.button粘贴.UseVisualStyleBackColor = true;
            this.button粘贴.Click += new System.EventHandler(this.button粘贴_Click);
            // 
            // button复制右边
            // 
            this.button复制右边.Location = new System.Drawing.Point(315, 10);
            this.button复制右边.Name = "button复制右边";
            this.button复制右边.Size = new System.Drawing.Size(62, 23);
            this.button复制右边.TabIndex = 7;
            this.button复制右边.Text = "复制右边";
            this.button复制右边.UseVisualStyleBackColor = true;
            this.button复制右边.Click += new System.EventHandler(this.button复制右边_Click);
            // 
            // button存储左边
            // 
            this.button存储左边.Location = new System.Drawing.Point(519, 10);
            this.button存储左边.Name = "button存储左边";
            this.button存储左边.Size = new System.Drawing.Size(62, 23);
            this.button存储左边.TabIndex = 8;
            this.button存储左边.Text = "存储左边";
            this.button存储左边.UseVisualStyleBackColor = true;
            this.button存储左边.Click += new System.EventHandler(this.button存储左边_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "字幕文件|*.srt|所有文件|*.*";
            this.saveFileDialog.Title = "选择要保存的字幕文件路径";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 364);
            this.Controls.Add(this.button存储左边);
            this.Controls.Add(this.button复制右边);
            this.Controls.Add(this.button粘贴);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxLeft);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.button选择文件);
            this.Controls.Add(this.textBoxFilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "srt文件转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Button button选择文件;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.Button button粘贴;
        private System.Windows.Forms.Button button复制右边;
        private System.Windows.Forms.Button button存储左边;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

