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
            int MinutesInHour = 60;
            int peopleCount;
            int visitMinutes = 10;
            int waitingHours;
            int waitingMinutes;
            Console.Write("Введите количество людей в очереди:");
            peopleCount    = Convert.ToInt32(Console.ReadLine());
            waitingHours   = (peopleCount * visitMinutes) / MinutesInHour;
            waitingMinutes = (peopleCount * visitMinutes) % MinutesInHour;
            Console.WriteLine($"Вы должны простоять в очереди {waitingHours} часов и {waitingMinutes} минут");
        }
    }
}
