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
            const int MinuteUnitHours = 60;

            int countPeople;
            int timeUnitPeople = 10;
            int timeWaitingHours, timeWaitingMinutes;
            Console.Write("Введите количество людей в очереди:");
            countPeople = Convert.ToInt32(Console.ReadLine());
            timeWaitingHours = (countPeople * timeUnitPeople) / 60;
            timeWaitingMinutes = (countPeople * timeUnitPeople) % 60;
            Console.WriteLine($"Вы должны простоять в очереди {timeWaitingHours} часов и {timeWaitingMinutes} минут");
        }
    }
}
