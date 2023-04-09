using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name     = "Иванов";
            string surname  = "Иван";
            Console.WriteLine($"Ваше имя - {name}. Ваша фамилия - {surname}");
            Console.WriteLine("Пожалуйста нажмите любую коавишу");
            Console.ReadKey();
            (name, surname) = (surname, name);
            Console.WriteLine($"Ваше имя - {name}. Ваша фамилия - {surname}");
            Console.ReadKey();
        }
    }
}
