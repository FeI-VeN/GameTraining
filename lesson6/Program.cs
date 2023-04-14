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
            int fullRowsWithImages;
            int remainderOfImages;

            fullRowsWithImages = imagesTotal / imagesInRow;
            remainderOfImages = imagesTotal % imagesInRow;
            Console.WriteLine($"Полностью заполненных рядов картинками - {fullRowsWithImages};\nСверх меры останется - {remainderOfImages}");
        }
    }
}
