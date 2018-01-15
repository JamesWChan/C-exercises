using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort2 test = new BubbleSort2();
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            Console.WriteLine("Hello, World!");
            test.printMessage();

            test.sortArray(arr);
            Console.ReadKey();
            
        }
    }
}
