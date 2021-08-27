using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cc_package_simplify.Common
{
    class NotifyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void DoNotify([CallerMemberName] string propName = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
