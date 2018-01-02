using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Weather.Utils.UI
{
    public class BaseViewModels :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<PropertyChangedEventArgs> OnPropertyChanged;

        public virtual void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }

            if (OnPropertyChanged != null)
            {
                OnPropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
