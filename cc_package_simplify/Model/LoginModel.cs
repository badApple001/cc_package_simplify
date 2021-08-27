using cc_package_simplify.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc_package_simplify.Model
{
    class LoginModel : NotifyBase
    {
        private string _userName;
        public string UserName { get { return _userName; } set { _userName = value; this.DoNotify(); } }

        private string _password;
        public string Password { get { return _password; } set { _password = value;this.DoNotify(); } }

        private string _validationCode;
        public string ValidationCode { get { return _validationCode; } set { _validationCode = value; this.DoNotify(); } }

        private string _errorMsg;
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; this.DoNotify(); }
        }


        private string _validationCodeUrl = "./Assets/ValidationCode/6vdY.png";
        public string ValidationCodeUrl
        {
            get { return _validationCodeUrl; }
            set { _validationCodeUrl = value; this.DoNotify(); }
        }

    }
}
