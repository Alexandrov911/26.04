using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" введите число a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" введите число a ");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                s = s + i * i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
