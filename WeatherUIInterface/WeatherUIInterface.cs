using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.UIInterface
{
    public interface WeatherUIInterface
    {
        void ShowErrorMessage(string sText);
        void SetWaitCursor(bool bWait);
    }
}
