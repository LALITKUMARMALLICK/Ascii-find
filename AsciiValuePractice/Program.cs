using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiValuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* char c = '$';
             int x = c;
             Console.WriteLine(x);
             Console.ReadLine();*/
             //OR
            string s;
            Console.WriteLine("enter the sentence");
            s = Console.ReadLine();
            foreach (char c in s) 
            {
                Console.WriteLine((int)c);
                Console.ReadLine();
            }

        }
    }
}
