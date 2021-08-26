using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace cc_package_simplify
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
            Exit += App_Exit;
        }

        void App_Exit(object sender, ExitEventArgs e)
        {
            Debug.log(">>>>>>>>>Application Exit");
            Debug.outLog();
        }

        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string err = "Error encountered! Please contact support." + Environment.NewLine + e.Exception.Message + "\n" + e.Exception.StackTrace;
            Debug.log(err);
            MessageBox.Show(err);
            e.Handled = true;
        }
    }
}
