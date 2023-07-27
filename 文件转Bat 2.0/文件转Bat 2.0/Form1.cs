using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 文件转Bat_2._0
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void 打赏链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://afdian.net/a/Zhuluoji");
        }

        private void 源代码链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/23286440/EndlessMessage");
        }

        private void Bilibili链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://space.bilibili.com/1927497544");
        }

        private void 文件选择按钮_Click(object sender, EventArgs e)
        {
            if (打开文件.ShowDialog() == DialogResult.OK)
            {
                文件路径输入框.Text = 打开文件.FileName;
            }
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            文件路径输入框.Text = filepaths[0];
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void 转化按钮_Click(object sender, EventArgs e)
        {
            string filepath = 文件路径输入框.Text;
            if (System.IO.File.Exists(filepath))
            {
                转化按钮.Enabled = false;
                转化按钮.Text = "转化中...";
                后台任务.RunWorkerAsync(filepath);
            }
            else
            {
                _ = MessageBox.Show("文件路径无效 ≧ ﹏ ≦", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 后台任务_DoWork(object sender, DoWorkEventArgs e)
        {
            string filepath = e.Argument.ToString();
            string fileName = System.IO.Path.GetFileName(filepath);
            List<string> 输出 = new List<string>
            {
                "@echo off",
                "goto CmdCode",
                "-----BEGIN CERTIFICATE-----"
            };
            // 读取文件数据
            byte[] 文件数据 = File.ReadAllBytes(filepath);
            // 将文件数据转换为Base64字符串
            string Base64数据 = Convert.ToBase64String(文件数据);

            输出.Add(Base64数据);

            输出.Add("-----END CERTIFICATE-----");
            输出.Add(":CmdCode");
            输出.Add("del " + fileName + " /F >NUL 2>NUL");
            输出.Add("certutil -decode %0 " + fileName + " >nul");
            输出.Add("start \"\" " + fileName);
            输出.Add("exit");

            e.Result = 输出;
        }

        private void 后台任务_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            转化按钮.Text = "转化";
            转化按钮.Enabled = true;

            if (e.Error == null) // 如果发生错误
            {
                List<string> resultList = e.Result as List<string>;

                //保存文件
                if (保存文件.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(保存文件.FileName, FileMode.Create))
                    {
                        foreach (string item in resultList)
                        {
                            byte[] bytes = Encoding.Default.GetBytes(item);
                            stream.Write(bytes, 0, bytes.Length);
                            stream.WriteByte((byte)'\n');
                        }
                    }

                }
            }
            else
            {
                _ = MessageBox.Show(e.Error.ToString(), "出错了 Σ(っ °Д °;)っ");
            }
        }
    }
}
