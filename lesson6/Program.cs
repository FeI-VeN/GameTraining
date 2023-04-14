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
            int imagesInRow = 3;
            int imagesTotal = 52;
            int countRowsOfThreeImages;
            int remainderOfImages;

            countRowsOfThreeImages = imagesTotal / imagesInRow;
            remainderOfImages = imagesTotal % imagesInRow;
            Console.WriteLine($"Полностью заполненных рядов картинками - {countRowsOfThreeImages};\nСверх меры останется - {remainderOfImages}");
        }
    }
}
