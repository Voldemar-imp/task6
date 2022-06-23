using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfImages = 52;
            int picturesInRow = 3;
            int picturesOutRow;
            int numberOfRow;

            numberOfRow = numberOfImages / picturesInRow;
            picturesOutRow = numberOfImages - numberOfRow * picturesInRow;

            Console.WriteLine("Количество рядов картинок - {0}. Картинок вне ряда - {1}", numberOfRow, picturesOutRow);                      
        }
    }
}
