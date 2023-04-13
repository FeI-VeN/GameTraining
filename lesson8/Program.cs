using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesInHour = 60;
            int peopleCount;
            int visitMinutes = 10;
            int waitingHours;
            int waitingMinutes;
            int visitTotalMinutes;

            Console.Write("Введите количество людей в очереди:");

            peopleCount = Convert.ToInt32(Console.ReadLine());
            visitTotalMinutes = peopleCount * visitMinutes;
            waitingHours = visitTotalMinutes / minutesInHour;
            waitingMinutes = visitTotalMinutes % minutesInHour;

            Console.WriteLine($"Вы должны простоять в очереди {waitingHours} часов и {waitingMinutes} минут");
        }
    }
}
