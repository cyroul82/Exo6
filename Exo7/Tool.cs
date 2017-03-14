using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo7
{
    public class Tool
    {

        public static Boolean Controle(String s)
        {
            Boolean flag = true;
            if (!(EstEntier(s)))
            {
                flag = false;
            }
            return flag;
        }


        public static Boolean EstEntier(String s)
        {
            Int32 i;
            Char c;
            Boolean code = true;

            if (s.Length < 10 && s.Length > 0)
            {
                for (i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;
                    }
                }
            }
            else
            {
                code = false;
            }
            return code;
        }
    }
}
