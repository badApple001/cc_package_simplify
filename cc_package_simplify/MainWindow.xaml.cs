using System;
using System.Windows;
using System.Windows.Controls;

using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ListView = System.Windows.Controls.ListView;
using DragEventArgs = System.Windows.DragEventArgs;
using DataFormats = System.Windows.DataFormats;
using SolidColorBrush = System.Windows.Media.SolidColorBrush;

namespace cc_package_simplify
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("wininet")]
        //判断网络状况的方法,返回值true为连接，false为未连接  
        public extern static bool InternetGetConnectedState(out int conState, int reder);

        public MainWindow()
        {
            Debug.log(">>>>>>>>>construct");

            InitializeComponent();

            int result = 0;
            IPlatform.CanNetworking = InternetGetConnectedState(out result, 0) == true;

            this.Loaded += (object sender, RoutedEventArgs e) =>
            {
                Debug.log(">>>>>>>>>loaded");

            };
            this.Closed += (object sender, EventArgs e) =>
            {
                Debug.log(">>>>>>>>>closed");
            };

            //mediaElement.Player.Volume = 
            Debug.setEditorText(editorText);



        }

        public void onFileDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ListView lv = sender as ListView;

            lv.Items.Clear();
            foreach (var str in files)
            {
                lv.Items.Add(str);
            }

        }

        private void Convert()
        {
            var start = DateTime.Now;
            Debug.log($"{start.ToString()}: Convert Start");

            foreach (var item in ls1.Items)
            {
                var webMobileUrl = item.ToString();
                new Thread(() =>
                {

                    string root = System.IO.Path.GetFileNameWithoutExtension(webMobileUrl);
                    new Converter(webMobileUrl).Output($"Publish/{root}");

                }).Start();
            }

            Debug.log($"{DateTime.Now.ToString()}: Convert End\nUsetime: {(DateTime.Now - start).TotalSeconds}sec");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            //创建对象
            ColorDialog colorDialog = new ColorDialog();
            //允许使用该对话框的自定义颜色  
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.ShowHelp = true;
            //初始化当前文本框中的字体颜色，  
            colorDialog.Color = System.Drawing.Color.White;

            //当用户在ColorDialog对话框中点击"确定"按钮  
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获取颜色，进行设置
                Debug.log($"color: {System.Drawing.ColorTranslator.ToHtml(colorDialog.Color)}");
            }


        }
    }
}
