using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace cc_package_simplify.Common
{
    public class PasswordHelper
    {

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof(string),typeof(PasswordHelper),
                new FrameworkPropertyMetadata("",new PropertyChangedCallback(OnPropertyChanged)));
      
        public static string GetPassowrd(DependencyObject d)
        {
            return d.GetValue(PasswordProperty).ToString();
        }

        public static void SetPassword(DependencyObject d,string value)
        {
            d.SetValue(PasswordProperty, value);
        }


        public static readonly DependencyProperty AttachProperty =
           DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PasswordHelper),
               new FrameworkPropertyMetadata(default(bool), new PropertyChangedCallback(OnAttached)));

        public static bool GetAttach(DependencyObject d)
        {
            return (bool)d.GetValue(AttachProperty);
        }

        public static void SetAttach(DependencyObject d, bool value)
        {
            d.SetValue(AttachProperty, value);
        }

        static bool _isUpdating = false;
        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var box = d as PasswordBox;
            box.PasswordChanged -= Password_PasswordChanged;
            if (!_isUpdating)
                box.Password = e.NewValue.ToString();
            box.PasswordChanged += Password_PasswordChanged;
        }

        private static void OnAttached(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var box = d as PasswordBox;
            box.PasswordChanged += Password_PasswordChanged;
        }

        public static void Password_PasswordChanged(object sender,RoutedEventArgs e)
        {

            var pb = sender as PasswordBox;
            _isUpdating = true;
            SetPassword(pb, pb.Password);
            _isUpdating = false;
        }



    }
}
