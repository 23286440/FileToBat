namespace 文件转Bat_2._0
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Bilibili链接 = new System.Windows.Forms.LinkLabel();
            this.源代码链接 = new System.Windows.Forms.LinkLabel();
            this.打赏链接 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.协议 = new System.Windows.Forms.Label();
            this.文件选择按钮 = new System.Windows.Forms.Button();
            this.文件路径输入框 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.转化按钮 = new System.Windows.Forms.Button();
            this.打开文件 = new System.Windows.Forms.OpenFileDialog();
            this.保存文件 = new System.Windows.Forms.SaveFileDialog();
            this.后台任务 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bilibili链接
            // 
            this.Bilibili链接.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bilibili链接.AutoSize = true;
            this.Bilibili链接.BackColor = System.Drawing.Color.Transparent;
            this.Bilibili链接.Location = new System.Drawing.Point(482, 112);
            this.Bilibili链接.Name = "Bilibili链接";
            this.Bilibili链接.Size = new System.Drawing.Size(53, 12);
            this.Bilibili链接.TabIndex = 21;
            this.Bilibili链接.TabStop = true;
            this.Bilibili链接.Text = "Bilibili";
            this.Bilibili链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Bilibili链接_LinkClicked);
            // 
            // 源代码链接
            // 
            this.源代码链接.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.源代码链接.AutoSize = true;
            this.源代码链接.BackColor = System.Drawing.Color.Transparent;
            this.源代码链接.Location = new System.Drawing.Point(435, 112);
            this.源代码链接.Name = "源代码链接";
            this.源代码链接.Size = new System.Drawing.Size(41, 12);
            this.源代码链接.TabIndex = 20;
            this.源代码链接.TabStop = true;
            this.源代码链接.Text = "源代码";
            this.源代码链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.源代码链接_LinkClicked);
            // 
            // 打赏链接
            // 
            this.打赏链接.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.打赏链接.AutoSize = true;
            this.打赏链接.BackColor = System.Drawing.Color.Transparent;
            this.打赏链接.Location = new System.Drawing.Point(400, 112);
            this.打赏链接.Name = "打赏链接";
            this.打赏链接.Size = new System.Drawing.Size(29, 12);
            this.打赏链接.TabIndex = 19;
            this.打赏链接.TabStop = true;
            this.打赏链接.Text = "打赏";
            this.打赏链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.打赏链接_LinkClicked);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(458, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "作者：侏罗纪";
            // 
            // 协议
            // 
            this.协议.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.协议.AutoSize = true;
            this.协议.BackColor = System.Drawing.Color.Transparent;
            this.协议.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.协议.Location = new System.Drawing.Point(381, 124);
            this.协议.Name = "协议";
            this.协议.Size = new System.Drawing.Size(154, 14);
            this.协议.TabIndex = 22;
            this.协议.Text = "本软件使用MIT许可协议";
            // 
            // 文件选择按钮
            // 
            this.文件选择按钮.Location = new System.Drawing.Point(447, 10);
            this.文件选择按钮.Name = "文件选择按钮";
            this.文件选择按钮.Size = new System.Drawing.Size(75, 23);
            this.文件选择按钮.TabIndex = 23;
            this.文件选择按钮.Text = "选择";
            this.文件选择按钮.UseVisualStyleBackColor = true;
            this.文件选择按钮.Click += new System.EventHandler(this.文件选择按钮_Click);
            // 
            // 文件路径输入框
            // 
            this.文件路径输入框.AllowDrop = true;
            this.文件路径输入框.Location = new System.Drawing.Point(131, 12);
            this.文件路径输入框.Name = "文件路径输入框";
            this.文件路径输入框.Size = new System.Drawing.Size(310, 21);
            this.文件路径输入框.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "选择要转化的文件：";
            // 
            // 转化按钮
            // 
            this.转化按钮.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.转化按钮.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("转化按钮.BackgroundImage")));
            this.转化按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.转化按钮.Cursor = System.Windows.Forms.Cursors.Hand;
            this.转化按钮.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.转化按钮.ForeColor = System.Drawing.Color.Violet;
            this.转化按钮.Location = new System.Drawing.Point(14, 77);
            this.转化按钮.Name = "转化按钮";
            this.转化按钮.Size = new System.Drawing.Size(111, 47);
            this.转化按钮.TabIndex = 26;
            this.转化按钮.Text = "转化";
            this.转化按钮.UseVisualStyleBackColor = true;
            this.转化按钮.Click += new System.EventHandler(this.转化按钮_Click);
            // 
            // 打开文件
            // 
            this.打开文件.FileName = "openFileDialog1";
            // 
            // 保存文件
            // 
            this.保存文件.DefaultExt = "bat";
            this.保存文件.Filter = "批处理文件 (*.bat)|*.bat|所有文件 (*.*)|*.*";
            // 
            // 后台任务
            // 
            this.后台任务.DoWork += new System.ComponentModel.DoWorkEventHandler(this.后台任务_DoWork);
            this.后台任务.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.后台任务_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(345, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "文件名需要是英文的QWQ";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(547, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.转化按钮);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.文件路径输入框);
            this.Controls.Add(this.文件选择按钮);
            this.Controls.Add(this.协议);
            this.Controls.Add(this.Bilibili链接);
            this.Controls.Add(this.源代码链接);
            this.Controls.Add(this.打赏链接);
            this.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "文件转Bat 2.0";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Bilibili链接;
        private System.Windows.Forms.LinkLabel 源代码链接;
        private System.Windows.Forms.LinkLabel 打赏链接;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label 协议;
        private System.Windows.Forms.Button 文件选择按钮;
        private System.Windows.Forms.TextBox 文件路径输入框;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 转化按钮;
        private System.Windows.Forms.OpenFileDialog 打开文件;
        private System.Windows.Forms.SaveFileDialog 保存文件;
        private System.ComponentModel.BackgroundWorker 后台任务;
        private System.Windows.Forms.Label label2;
    }
}

