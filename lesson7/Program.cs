using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystalsCount;
            int sum;
            int crystalPrice = 10;

            Console.WriteLine("Здравствуйте, скажите насколько полон ваш кошелек?");

            money = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Добро пожаловать в магазин CraftMen! Не хотите купить кристаллы? Сегодня их цена {crystalPrice} золота за 1 штуку.");
            Console.Write("Скажите сколько кристалов вы хотите приобрести? Не волнуйтесь, если вам не хватит денег. Вы сможете недостающую сумму принести потом.");
            
            crystalsCount = Convert.ToInt32(Console.ReadLine());
            sum = crystalsCount * crystalPrice;
            money -= sum;

            Console.WriteLine($"Вы приобрели {crystalsCount} кристалов. На сумму {sum} золота. У вас осталось {money} золота");
        }
    }
}
