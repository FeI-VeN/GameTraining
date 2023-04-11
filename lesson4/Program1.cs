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
            const int FirstMonthCommand    = 1;
            const int SecondMonthCommand   = 2;
            const int ThirdMonthCommand    = 3;
            const int FourthMonthCommand   = 4;
            const int FifthMonthCommand    = 5;
            const int SixthMonthCommand    = 6;
            const int SeventhMonthCommand  = 7;
            const int EighthMonthCommand   = 8;
            const int NinthMonthCommand    = 9;
            const int TenthMonthCommand    = 10;
            const int EleventhMonthCommand = 11;
            const int TwelfthMonthCommand  = 12;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name;
            int age = 0;
            string zodiacSign = "";
            int numberMonth;
            string nameMonth = "";
            int error = 0;
            bool correctInput = false;
            Console.Write("Как вас зовут? ");
            name = Convert.ToString(Console.ReadLine());

            while (correctInput == false)
            {
                Console.Write("Сколько вам лет? ");

                if (int.TryParse(Console.ReadLine(), out age) == true)
                {
                    age = Convert.ToInt32(age);
                    correctInput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }

            Console.Write("В каком месяце вы родились? Пожалуйста задайте месяц числом.");

            if (int.TryParse(Console.ReadLine(), out numberMonth) == true)
            {
                numberMonth = Convert.ToInt32(numberMonth);
            } 
            else
            {
                numberMonth = 0;
            }

            switch (numberMonth)
            {
                case FirstMonthCommand:
                    zodiacSign = "Водолей";
                    nameMonth = "Январь";
                    break;
                case SecondMonthCommand:
                    zodiacSign = "Рыбы";
                    nameMonth = "Февраль";
                    break;
                case ThirdMonthCommand:
                    zodiacSign = "Овен";
                    nameMonth = "Март";
                    break;
                case FourthMonthCommand:
                    zodiacSign = "Телец";
                    nameMonth = "Апрель";
                    break;
                case FifthMonthCommand:
                    zodiacSign = "Близнецы";
                    nameMonth = "Май";
                    break;
                case SixthMonthCommand:
                    zodiacSign = "Рак";
                    nameMonth = "Июнь";
                    break;
                case SeventhMonthCommand:
                    zodiacSign = "Лев";
                    nameMonth = "Июль";
                    break;
                case EighthMonthCommand:
                    zodiacSign = "Дева";
                    nameMonth = "Август";
                    break;
                case NinthMonthCommand:
                    zodiacSign = "Весы";
                    nameMonth = "Сентябрь";
                    break;
                case TenthMonthCommand:
                    zodiacSign = "Скорпион";
                    nameMonth = "Октябрь";
                    break;
                case EleventhMonthCommand:
                    zodiacSign = "Стрелец";
                    nameMonth = "Ноябрь";
                    break;
                case TwelfthMonthCommand:
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
