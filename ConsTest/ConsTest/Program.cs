using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest
{
    public class Program
    {
        public Program(string myString)
        {
            Console.WriteLine(myString);
        }
        static int GetRandom()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 10);
            return value;
        }
        public static void Main()
        {
            Console.Write("N = ");
            string nVar = Console.ReadLine();
            int nVarConverted = Convert.ToInt32(nVar);
            StringGenerator NewString = new StringGenerator(nVarConverted);
        }
    }
}
