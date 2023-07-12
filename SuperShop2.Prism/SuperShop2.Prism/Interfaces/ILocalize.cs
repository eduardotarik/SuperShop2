using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SuperShop2.Prism.Interfaces
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
