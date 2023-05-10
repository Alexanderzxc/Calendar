using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class calendar
    {
        public string GetDate(int day, int month, int year)
        {
            if (month<10)
            {
                string s = string.Format("Сейчас: {0}.0{1}.{2}", day, month, year);
                return s;
            }
            else
            {
                string s = string.Format("Сейчас: {0}.{1}.{2}", day, month, year);
                return s;
            }

        }

    }
}
