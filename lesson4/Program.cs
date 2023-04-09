using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name;
            int age;
            string zodiacSign = "";
            int month;
            string nameMonth = "";
            int error = 0;
            Console.Write("Как вас зовут? ");
            name = Convert.ToString(Console.ReadLine());
            while (true)
            {
                Console.Write("Сколько вам лет? ");
                if (int.TryParse(Console.ReadLine(), out age) == true)
                {
                    age = Convert.ToInt32(age);
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }
            Console.Write("В каком месяце вы родились? Пожалуйста задайте месяц числом.");
            if (int.TryParse(Console.ReadLine(), out month) == true)
            {
                month = Convert.ToInt32(month);
            } else
            {
                month = 0;
            }
            if (age != 0)
            {

            }
            switch (month)
            {
                case 1:
                    zodiacSign = "Водолей";
                    nameMonth = "Январь";
                    break;
                case 2:
                    zodiacSign = "Рыбы";
                    nameMonth = "Февраль";
                    break;
                case 3:
                    zodiacSign = "Овен";
                    nameMonth = "Март";
                    break;
                case 4:
                    zodiacSign = "Телец";
                    nameMonth = "Апрель";
                    break;
                case 5:
                    zodiacSign = "Близнецы";
                    nameMonth = "Май";
                    break;
                case 6:
                    zodiacSign = "Рак";
                    nameMonth = "Июнь";
                    break;
                case 7:
                    zodiacSign = "Лев";
                    nameMonth = "Июль";
                    break;
                case 8:
                    zodiacSign = "Дева";
                    nameMonth = "Август";
                    break;
                case 9:
                    zodiacSign = "Весы";
                    nameMonth = "Сентябрь";
                    break;
                case 10:
                    zodiacSign = "Скорпион";
                    nameMonth = "Октябрь";
                    break;
                case 11:
                    zodiacSign = "Стрелец";
                    nameMonth = "Ноябрь";
                    break;
                case 12:
                    zodiacSign = "Козерог";
                    nameMonth = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Вы ввели не корректный месяц. Вам придется пройти тест заново");
                    error = 1;
                    Console.ReadKey();
                    break;
            }
            if (error == 0)
            {
                Console.WriteLine($"Вас зовут {name}.\n" +
                    $"Ваш возраст - {age}.\n" +
                    $"Ваш месяц рождения {nameMonth}\n" +
                    $"Ваш знак зодиака {zodiacSign}");
                Console.ReadKey();
            } 
        }
    }
}
