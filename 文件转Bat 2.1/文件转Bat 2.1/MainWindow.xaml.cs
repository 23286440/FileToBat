using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace 文件转Bat_2._1
{
    public partial class MainWindow : Window
    {
        private bool 鼠标是否按下 = false;
        private Point 起始点;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void 打赏链接_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://afdian.net/a/Zhuluoji");
        }

        private void 源代码链接_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/23286440/EndlessMessage");
        }

        private void Bilibili链接_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://space.bilibili.com/1927497544");
        }

        private void 关闭按钮_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (鼠标是否按下)
            {
                Point 当前位置 = e.GetPosition(this);
                double 变化_X = 当前位置.X - 起始点.X;
                double 变化_Y = 当前位置.Y - 起始点.Y;

                Left += 变化_X;
                Top += 变化_Y;
            }
        }

        private void window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                鼠标是否按下 = false;
                ReleaseMouseCapture();
            }
        }

        private void window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                起始点 = e.GetPosition(this);
                鼠标是否按下 = true;
                _ = CaptureMouse();
            }
        }

        private void 文件路径输入框_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "全部文件 (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                文件路径输入框.Text = filePath;
            }
        }

        private void window_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void window_Drop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            文件路径输入框.Text = filepaths[0];
        }

        private async void 转化按钮_Click(object sender, RoutedEventArgs e)
        {
            string openfilePath = 文件路径输入框.Text;
            if (System.IO.File.Exists(openfilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "批处理文件 (*.bat)|*.bat|文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*",
                    Title = "选择保存文件位置"
                };
                if (saveFileDialog.ShowDialog() == true)
                {
                    string savefilePath = saveFileDialog.FileName;
                    转化按钮.IsEnabled = false;
                    转化按钮.Content = "转化中...";
                    await Task.Run(() => 文件处理(openfilePath, savefilePath));
                    转化按钮.IsEnabled = true;
                    转化按钮.Content = "    转化\r\n(っ °Д °;)っ";
                }
            }
            else
            {
                _ = MessageBox.Show("文件路径无效 ≧ ﹏ ≦", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void 文件处理(string openFilePath, string saveFilePath)
        {
            string fileName = System.IO.Path.GetFileName(openFilePath);
            string content = "@echo off" + Environment.NewLine +
                             "del " + fileName + " /F >NUL 2>NUL" + Environment.NewLine +
                             "certutil -decode %0 " + fileName + " >nul" + Environment.NewLine +
                             "start \"\" " + fileName + Environment.NewLine +
                             "exit" + Environment.NewLine +
                             "-----BEGIN CERTIFICATE-----\n";

            File.WriteAllText(saveFilePath, content, Encoding.Default);
            ConvertFileToBase64(openFilePath, saveFilePath);
            File.AppendAllText(saveFilePath, "\n-----END CERTIFICATE-----", Encoding.Default);
        }

        public static void ConvertFileToBase64(string openFilePath, string saveFilePath)
        {
            using (FileStream fileStream = new FileStream(openFilePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream))
            using (FileStream base64Stream = new FileStream(saveFilePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(base64Stream))
            {
                byte[] buffer = new byte[129140163];  // 控制内存占用的缓冲区大小，可以根据需要进行调整;单位：字节，要为3的倍数
                int bytesRead;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string base64String = Convert.ToBase64String(buffer, 0, bytesRead);
                    writer.Write(base64String);
                }
            }
        }
    }
}
