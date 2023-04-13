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
            string currentZodiacSign = "";
            int monthNumber;
            string monthName = "";
            string currentMonthName = "";
            bool isError = false;
            bool isCorrectInput = false;
            Console.Write("Как вас зовут? ");
            name = Convert.ToString(Console.ReadLine());

            while (isCorrectInput == false)
            {
                Console.Write("Сколько вам лет? ");

                if (int.TryParse(Console.ReadLine(), out age) == true)
                {
                    age = Convert.ToInt32(age);
                    isCorrectInput  = true;
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }

            Console.Write("В каком месяце вы родились? Пожалуйста задайте месяц числом.");

            if (int.TryParse(Console.ReadLine(), out monthNumber) == true)
            {
                monthNumber = Convert.ToInt32(monthNumber);
            } 
            else
            {
                monthNumber = 0;
            }

            switch (monthNumber)
            {
                case FirstMonthCommand:
                    currentZodiacSign = "Водолей";
                    currentMonthName = "Январь";
                    break;

                case SecondMonthCommand:
                    currentZodiacSign = "Рыбы";
                    currentMonthName = "Февраль";
                    break;

                case ThirdMonthCommand:
                    currentZodiacSign = "Овен";
                    currentMonthName = "Март";
                    break;

                case FourthMonthCommand:
                    currentZodiacSign = "Телец";
                    currentMonthName = "Апрель";
                    break;

                case FifthMonthCommand:
                    currentZodiacSign = "Близнецы";
                    currentMonthName = "Май";
                    break;

                case SixthMonthCommand:
                    currentZodiacSign = "Рак";
                    currentMonthName = "Июнь";
                    break;

                case SeventhMonthCommand:
                    currentZodiacSign = "Лев";
                    currentMonthName = "Июль";
                    break;

                case EighthMonthCommand:
                    currentZodiacSign = "Дева";
                    currentMonthName = "Август";
                    break;

                case NinthMonthCommand:
                    currentZodiacSign = "Весы";
                    currentMonthName = "Сентябрь";
                    break;

                case TenthMonthCommand:
                    currentZodiacSign = "Скорпион";
                    currentMonthName = "Октябрь";
                    break;

                case EleventhMonthCommand:
                    currentZodiacSign = "Стрелец";
                    currentMonthName = "Ноябрь";
                    break;

                case TwelfthMonthCommand:
                    currentZodiacSign = "Козерог";
                    currentMonthName = "Декабрь";
                    break;

                default:
                    Console.WriteLine("Вы ввели не корректный месяц. Вам придется пройти тест заново");
                    isError = true;
                    Console.ReadKey();
                    break;
            }

            if (isError == false)
            {
                monthName = currentMonthName;
                zodiacSign = currentZodiacSign;
                Console.WriteLine($"Вас зовут {name}.\n" +
                    $"Ваш возраст - {age}.\n" +
                    $"Ваш месяц рождения {monthName}\n" +
                    $"Ваш знак зодиака {zodiacSign}");
                Console.ReadKey();
            } 
        }
    }
}
