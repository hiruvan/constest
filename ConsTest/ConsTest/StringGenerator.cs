using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest
{
    class StringGenerator
    {
        public StringGenerator(int StringQuantity)
        {
            int iter = 1;
            while (iter <= StringQuantity)
            {
                Program Result = new Program(GenerateString(iter));
                iter++;
            }
        }
        static string GenerateString(int iter)
        {
            var chars = "ABCDEFGHIKJKLMNOPQRSTUVWXYZ";
            Random rnd = new Random(iter);
            int i = 0;
            int charQuan = rnd.Next(1, 10);
            string myString = "";
            while (i <= charQuan)
            {
                myString = myString + chars[rnd.Next(chars.Length)];
                if (i != charQuan)
                {
                    myString = myString + "+";
                }
                i++;
            }
            return myString;
        }
    }
}
