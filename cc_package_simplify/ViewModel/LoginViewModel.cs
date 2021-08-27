using cc_package_simplify.Common;
using cc_package_simplify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cc_package_simplify.ViewModel
{
    class LoginViewModel
    {

        public CommandBase CloseWindowCommand { get; set; }
        public CommandBase LoginCommand { get; set; }


        public LoginModel loginModel { get; set; }

        public string[] validateCode = new string[] {
            "6vdY",
            "BpDY",
            "eZL5",
            "twgA",
            "V9rN",
            "ZHWO",
        };
        public string currentValidateCode = "";
        public string randomValidateCode()
        {
            int index = new Random().Next(0, this.validateCode.Length);
            var code = validateCode[index];
            currentValidateCode = code;
            return $"./Assets/ValidationCode/{code}.png";
        }

        public LoginViewModel()
        {

            this.loginModel = new LoginModel();
            this.loginModel.UserName = "";
            this.loginModel.ValidationCode = "";
            this.loginModel.Password = "123123";



            this.loginModel.ValidationCodeUrl = randomValidateCode();




            this.CloseWindowCommand = new CommandBase();
            this.CloseWindowCommand.DoExecute = new Action<object>((o) => {
                
                (o as Window).Close();
            });
            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });



            this.LoginCommand = new CommandBase();
            this.LoginCommand.DoExecute = new Action<object>(Login);
            this.LoginCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

        }

        private void Login(object o)
        {
            loginModel.ErrorMsg = "";
            if (string.IsNullOrEmpty(loginModel.UserName))
            {
                loginModel.ErrorMsg = "请输入用户名！";
                return;
            }
            if (string.IsNullOrEmpty(loginModel.Password))
            {
                loginModel.ErrorMsg = "请输入密码！";
                return;
            }
            if (string.IsNullOrEmpty(loginModel.ValidationCode))
            {
                loginModel.ErrorMsg = "请输入验证码！";
                return;
            }


            if(this.loginModel.ValidationCode.ToLower() == this.currentValidateCode.ToLower())
            {
                Console.WriteLine("验证码正确");


            }

        }



    }
}
