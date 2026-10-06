using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите true или false: ");
            string input = Console.ReadLine();

            if (bool.TryParse(input, out bool val))
            {
                Console.WriteLine($"Инверсия: {!val}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите строго true или false (регистр не важен).");
            }
        }
    }
}

