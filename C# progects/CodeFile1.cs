using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 2, 6 };

            int y = 0;

            foreach (int x in arr)
            {

                y += x / 2;

            }

            Console.Write(y);
        }
    }
}