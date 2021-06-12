using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Runtime.InteropServices;

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
            IPlatform.CanNetworking = InternetGetConnectedState(out result,0) == true;

            this.Loaded += (object sender, RoutedEventArgs e) => {
                Debug.log(">>>>>>>>>loaded");
            };
            this.Closed += (object sender, EventArgs e) => {
                Debug.log(">>>>>>>>>closed");
            };
            
        }


    }
}
