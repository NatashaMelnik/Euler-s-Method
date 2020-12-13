using System;

namespace Taylor_s_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0;
            double y0 = 1;
            double h = 0.1;

            double a = 0;
            double b = 5;

            Console.WriteLine("Euler's Method for solving differential equation:");

            Console.WriteLine();

            Console.WriteLine($"y' = t^2 - y  on  [{a}; {b}] with {h} step, check on  y(t) = -e^-t +t^2 - 2t + 2");
            Console.WriteLine();
            Euler(x0, y0, h, a, b);


            Console.WriteLine($"y' = t^2 - y  on  [{a}; {b}] with {h/2} step, check on  y(t) = -e^-t +t^2 - 2t + 2");
            Console.WriteLine();
            Euler(x0, y0, h/2, a, b);

            Console.ReadKey();
        }

        static void Euler(double x0, double y, double h, double a, double b)
        {
            double y05;

            for (double i = a; i <b; i = i + h)
            {
                y05 = y + h / 2 * GetFunction(x0, y);
                y = y + h * GetFunction(x0 + h / 2, y05);

                Console.Write($"({x0}; {y})");
                checkFunction(y, x0);

                x0 = x0 + h;                
            }

            Console.WriteLine();
        }

        static void checkFunction(double y, double t)
        {
            double yt = -Math.Pow(Math.E, -t) + t * t - 2 * t + 2;
            Console.Write($"  -  {yt}");
            Console.WriteLine();
        }

        static double GetFunction(double t, double y)
        {
            return t * t - y;
        }
    }
}
