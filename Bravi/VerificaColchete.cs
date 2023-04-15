using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravi
{
    internal class VerificaColchete
    {
        public void VerificaColchetes(string value)
        {
            if (value.Count() % 2 == 0) {
               
                int i = value.Count();

                for (int a = i; a > 0; a--)
                {
                    string subs = value.Replace("[]", "");
                    string subs1 = subs.Replace("()", "");
                    string subs2 = subs1.Replace("{}", "");
                    value = subs2;                    
                }
                
                if (value != "")
                {
                    Console.WriteLine("Sua palavra é inválida");
                }
                else
                {
                    Console.WriteLine("Sua palavra é válida!");
                }
            }
            else {
                
                Console.WriteLine("Sua palavra é inválida");
            }

        }
    }
}
