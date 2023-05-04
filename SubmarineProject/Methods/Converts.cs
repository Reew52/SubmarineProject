using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineProject.Methods
{
    public static class Converts
    {
        public static float convertStringToFloat(this string str)
        {
                float fl = float.Parse(str);
                return fl;
        }
        public static string convertFloatToString(this float fl)
        {
            string str= Convert.ToString(fl);
            return str;
        }
    }
}
