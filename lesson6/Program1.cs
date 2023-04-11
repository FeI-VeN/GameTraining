using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countRowImage    = 3;
            int totalCountImage  = 52;
            int fullRowImage, remainImage;

            fullRowImage = totalCountImage / countRowImage;
            remainImage = totalCountImage % countRowImage;
            Console.WriteLine($"Полностью заполненных рядов картинками - {fullRowImage};\nСверх меры останется - {remainImage}");

        }
    }
}
