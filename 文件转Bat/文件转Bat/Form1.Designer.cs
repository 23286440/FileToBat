namespace 文件转Bat
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
            this.打开文件 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.选择文件按钮 = new System.Windows.Forms.Button();
            this.目标文件 = new System.Windows.Forms.TextBox();
            this.保存文件 = new System.Windows.Forms.SaveFileDialog();
            this.转化按钮 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.中间文件文件名_vbs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.中间文件文件名_base64 = new System.Windows.Forms.TextBox();
            this.后台任务 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.进度条 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.打赏链接 = new System.Windows.Forms.LinkLabel();
            this.源代码链接 = new System.Windows.Forms.LinkLabel();
            this.Bilibili链接 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择要转换的文件：";
            // 
            // 选择文件按钮
            // 
            this.选择文件按钮.Location = new System.Drawing.Point(556, 10);
            this.选择文件按钮.Name = "选择文件按钮";
            this.选择文件按钮.Size = new System.Drawing.Size(83, 33);
            this.选择文件按钮.TabIndex = 1;
            this.选择文件按钮.Text = "选择";
            this.选择文件按钮.UseVisualStyleBackColor = true;
            this.选择文件按钮.Click += new System.EventHandler(this.选择文件按钮_Click);
            // 
            // 目标文件
            // 
            this.目标文件.Location = new System.Drawing.Point(132, 17);
            this.目标文件.Name = "目标文件";
            this.目标文件.Size = new System.Drawing.Size(418, 21);
            this.目标文件.TabIndex = 2;
            // 
            // 保存文件
            // 
            this.保存文件.DefaultExt = "bat";
            this.保存文件.Filter = "批处理文件 (*.bat)|*.bat|所有文件 (*.*)|*.*";
            // 
            // 转化按钮
            // 
            this.转化按钮.Location = new System.Drawing.Point(14, 79);
            this.转化按钮.Name = "转化按钮";
            this.转化按钮.Size = new System.Drawing.Size(84, 36);
            this.转化按钮.TabIndex = 3;
            this.转化按钮.Text = "转化";
            this.转化按钮.UseVisualStyleBackColor = true;
            this.转化按钮.Click += new System.EventHandler(this.转化按钮_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "中间文件文件名_vbs：";
            // 
            // 中间文件文件名_vbs
            // 
            this.中间文件文件名_vbs.Location = new System.Drawing.Point(132, 51);
            this.中间文件文件名_vbs.Name = "中间文件文件名_vbs";
            this.中间文件文件名_vbs.Size = new System.Drawing.Size(76, 21);
            this.中间文件文件名_vbs.TabIndex = 5;
            this.中间文件文件名_vbs.Text = "DeCode.vbs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "中间文件文件名_base64：";
            // 
            // 中间文件文件名_base64
            // 
            this.中间文件文件名_base64.Location = new System.Drawing.Point(363, 51);
            this.中间文件文件名_base64.Name = "中间文件文件名_base64";
            this.中间文件文件名_base64.Size = new System.Drawing.Size(76, 21);
            this.中间文件文件名_base64.TabIndex = 7;
            this.中间文件文件名_base64.Text = "base64";
            // 
            // 后台任务
            // 
            this.后台任务.WorkerReportsProgress = true;
            this.后台任务.DoWork += new System.ComponentModel.DoWorkEventHandler(this.后台任务_DoWork);
            this.后台任务.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.后台任务_ProgressChanged);
            this.后台任务.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.后台任务_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(485, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "本软件使用MIT许可协议";
            // 
            // 进度条
            // 
            this.进度条.Location = new System.Drawing.Point(104, 92);
            this.进度条.Name = "进度条";
            this.进度条.Size = new System.Drawing.Size(535, 23);
            this.进度条.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "作者：侏罗纪";
            // 
            // 打赏链接
            // 
            this.打赏链接.AutoSize = true;
            this.打赏链接.Location = new System.Drawing.Point(446, 67);
            this.打赏链接.Name = "打赏链接";
            this.打赏链接.Size = new System.Drawing.Size(29, 12);
            this.打赏链接.TabIndex = 11;
            this.打赏链接.TabStop = true;
            this.打赏链接.Text = "打赏";
            this.打赏链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.打赏链接_LinkClicked);
            // 
            // 源代码链接
            // 
            this.源代码链接.AutoSize = true;
            this.源代码链接.Location = new System.Drawing.Point(481, 67);
            this.源代码链接.Name = "源代码链接";
            this.源代码链接.Size = new System.Drawing.Size(41, 12);
            this.源代码链接.TabIndex = 12;
            this.源代码链接.TabStop = true;
            this.源代码链接.Text = "源代码";
            this.源代码链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.源代码链接_LinkClicked);
            // 
            // Bilibili链接
            // 
            this.Bilibili链接.AutoSize = true;
            this.Bilibili链接.Location = new System.Drawing.Point(528, 67);
            this.Bilibili链接.Name = "Bilibili链接";
            this.Bilibili链接.Size = new System.Drawing.Size(53, 12);
            this.Bilibili链接.TabIndex = 13;
            this.Bilibili链接.TabStop = true;
            this.Bilibili链接.Text = "Bilibili";
            this.Bilibili链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Bilibili链接_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(651, 137);
            this.Controls.Add(this.Bilibili链接);
            this.Controls.Add(this.源代码链接);
            this.Controls.Add(this.打赏链接);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.进度条);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.中间文件文件名_base64);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.中间文件文件名_vbs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.转化按钮);
            this.Controls.Add(this.目标文件);
            this.Controls.Add(this.选择文件按钮);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "文件转Bat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog 打开文件;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 选择文件按钮;
        private System.Windows.Forms.TextBox 目标文件;
        private System.Windows.Forms.SaveFileDialog 保存文件;
        private System.Windows.Forms.Button 转化按钮;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 中间文件文件名_vbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 中间文件文件名_base64;
        private System.ComponentModel.BackgroundWorker 后台任务;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar 进度条;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel 打赏链接;
        private System.Windows.Forms.LinkLabel 源代码链接;
        private System.Windows.Forms.LinkLabel Bilibili链接;
    }
}

