using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 文件转Bat
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 选择文件按钮_Click(object sender, EventArgs e)
        {
            if (打开文件.ShowDialog() == DialogResult.OK)
            {
                目标文件.Text = 打开文件.FileName;
                目标文件拓展名 = Path.GetExtension(目标文件.Text);
            }
        }

        private void 界面控制(bool 状态)
        {
            转化按钮.Text = 状态 ? "转化" : "运行中...";
            转化按钮.Enabled = 状态;
            选择文件按钮.Enabled = 状态;

            目标文件.ReadOnly = !状态;
            中间文件文件名_vbs.ReadOnly = !状态;
            中间文件文件名_base64.ReadOnly = !状态;

        }

        private string 目标文件拓展名;
        private void 转化按钮_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(目标文件.Text) && (!string.IsNullOrEmpty(中间文件文件名_base64.Text)) && (!string.IsNullOrEmpty(中间文件文件名_vbs.Text)))
            {
                界面控制(false);
                后台任务.RunWorkerAsync(目标文件.Text);
            }
            else
            {
                _ = MessageBox.Show("文件路径无效，或中间文件名称设置为空 ≧ ﹏ ≦", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 后台任务_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // 读取文件数据
                byte[] 文件数据 = File.ReadAllBytes(目标文件.Text);
                // 将文件数据转换为Base64字符串
                string Base64数据 = Convert.ToBase64String(文件数据);


                // 定义每个项的长度
                int 每项长度 = 8191 - 中间文件文件名_base64.Text.Length;

                List<string> 列表 = new List<string>
                {
                    "@echo off",
                    "del "+中间文件文件名_base64.Text+" >NUL 2>NUL",
                    "goto Base64_Data",
                    ":Run",
                    "echo Option Explicit  >"+中间文件文件名_vbs.Text,
                    "echo Const FilePath = \""+中间文件文件名_base64.Text+"\"  >>"+中间文件文件名_vbs.Text,
                    "echo Const OutputPath = \"output"+目标文件拓展名+"\"  >>"+中间文件文件名_vbs.Text,
                    "echo Dim Base64Data: With CreateObject(\"Scripting.FileSystemObject\").OpenTextFile(FilePath)  >>"+中间文件文件名_vbs.Text,
                    "echo     Base64Data = .ReadAll: .Close: End With  >>"+中间文件文件名_vbs.Text,
                    "echo Dim Stream: Set Stream = CreateObject(\"ADODB.Stream\")  >>"+中间文件文件名_vbs.Text,
                    "echo Stream.Type = 1: Stream.Open  >>"+中间文件文件名_vbs.Text,
                    "echo Stream.Write DecodeBase64(Base64Data)  >>"+中间文件文件名_vbs.Text,
                    "echo Stream.SaveToFile OutputPath, 2  >>"+中间文件文件名_vbs.Text,
                    "echo Stream.Close  >>"+中间文件文件名_vbs.Text,
                    "echo Function DecodeBase64(ByVal base64)  >>"+中间文件文件名_vbs.Text,
                    "echo     Dim DM, EL: Set DM = CreateObject(\"Microsoft.XMLDOM\"): Set EL = DM.createElement(\"tmp\")  >>"+中间文件文件名_vbs.Text,
                    "echo     With CreateObject(\"Microsoft.XMLDOM\").createElement(\"tmp\")  >>"+中间文件文件名_vbs.Text,
                    "echo         .DataType = \"bin.base64\": .Text = base64: DecodeBase64 = .NodeTypedValue: End With  >>"+中间文件文件名_vbs.Text,
                    "echo Set DM = Nothing: Set EL = Nothing  >>"+中间文件文件名_vbs.Text,
                    "echo End Function  >>"+中间文件文件名_vbs.Text,
                    "start /wait wscript.exe "+中间文件文件名_vbs.Text,
                    "del "+中间文件文件名_vbs.Text+"&del "+中间文件文件名_base64.Text,
                    "start \"\" output"+目标文件拓展名,
                    "exit",
                    ":Base64_Data"
                };

                // 分割Base64字符串
                for (int i = 0; i < Base64数据.Length; i += 每项长度)
                {
                    int 进度 = (int)((long)i * 100 / Base64数据.Length);//解决溢出问题
                    后台任务.ReportProgress(进度);
                    int length = Math.Min(每项长度, Base64数据.Length - i);
                    string 项 = Base64数据.Substring(i, length);
                    列表.Add("echo " + 项 + " >>" + 中间文件文件名_base64.Text);
                }

                列表.Add("goto Run");
                后台任务.ReportProgress(100);
                e.Result = 列表;

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.ToString(), "出错了 Σ(っ °Д °;)っ");
            }
        }

        private void 后台任务_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            界面控制(true);
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
                            byte[] bytes = Encoding.UTF8.GetBytes(item); // 将字符串转换为 UTF-8 编码的字节数组
                            stream.Write(bytes, 0, bytes.Length); // 将字节数组写入文件
                            stream.WriteByte((byte)'\n'); // 写入换行符
                        }
                    }
                }
            }
        }

        private void 后台任务_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;
            进度条.Value = progress;
        }

        private void 打赏链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://afdian.net/a/Zhuluoji");
        }
        private void 源代码链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/23286440/FileToBat");
        }
        private void Bilibili链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://space.bilibili.com/1927497544");
        }

    }
}