using System;
using System.IO;
using System.Collections.Generic;

namespace AB
{
    public class Program
    {
        public class Bird
        {
            List<double> Coord1 = new List<double>();
            List<double> Coord2 = new List<double>();

            public void Fly()
            {
                const double g = 9.81, pi = Math.PI;
                double alpha, v, t, T, deltaT = 0.1;
                using (StreamReader read = new StreamReader("дано.txt"))
                {
                    v = Convert.ToDouble(read.ReadLine());
                    alpha = Convert.ToDouble(read.ReadLine());
                    alpha = alpha * pi / 180;
                    T = 2 * v * Math.Sin(alpha) / g;
                }

                double x = 0;
                double y = 0;
                double Vx = v * Math.Cos(alpha);
                double Vy = v * Math.Sin(alpha);

                for (t = 0; t <= T; t += deltaT)
                {
                    x = x + Vx * deltaT;
                    y = y + Vy * deltaT;
                    Vy = Vy - g * deltaT;
                    Coord1.Add(x);
                    Coord2.Add(y);
                }

                using (StreamWriter write = new StreamWriter("итог.txt"))
                {
                    for (int n = 0; n < Coord1.Count; n++)
                    {
                        write.WriteLine($"x = {Coord1[n]}");
                    }
                    for (int m = 0; m < Coord2.Count; m++)
                    {
                        write.WriteLine($"y = {Coord2[m]}");
                    }
                }
            }

            public static void Udar()
            {
                Console.WriteLine("Произошло столкновение!");
            }

            public delegate void UdarDelegate();

            public event UdarDelegate Stolk;

            public void Proverka()
            {
                for (int i = 0; i < Coord1.Count; i++)
                {
                    if (Coord1[i] >= 7)
                    {
                        Stolk();
                        return;
                    }
                }
            }

        }

        public static void Main()
        {
            Bird redB = new Bird();
            redB.Stolk += Bird.Udar;
            redB.Fly();
            redB.Proverka();
        }
    }
}
