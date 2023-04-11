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
            int countCrystal;
            int sum;
            int crystalPrice = 10;
            Console.WriteLine("Здравствуйте, скажите насколько полон ваш кошелек?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Добро пожаловать в магазин CraftMen! Не хотите купить кристаллы? Сегодня их цена {crystalPrice} золота за 1 штуку.");
            Console.Write("Скажите сколько кристалов вы хотите приобрести? Не волнуйтесь, если вам не хватит денег. Вы сможете недостающую сумму принести потом.");
            countCrystal = Convert.ToInt32(Console.ReadLine());
            sum = countCrystal * crystalPrice;
            money = money - (countCrystal * crystalPrice);
            Console.WriteLine($"Вы приобрели {countCrystal} кристалов. На сумму {sum} золота. У вас осталось {money} золота");
        }
    }
}
