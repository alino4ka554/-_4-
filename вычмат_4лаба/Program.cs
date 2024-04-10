using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вычмат_4лаба
{
    internal class Program
    {
        static float function(float x)
        {
            return (10 * x * x);
        }

        static float proizv(float xi, float x)
        {
            float h = xi - x;
            float f;
            f= (function(xi) - function(x))/h;
            return f;
        }


        
        static void Main(string[] args)
        {
            
            for (int i = -2; i >= -8; i--)
            {
                float x = (float)Math.Pow(10, -2);
                Console.WriteLine($"Производная в точке 10^-2 с шагом 10^{i} равна {proizv(x + (float)Math.Pow(10, i), x)}");
            }
            Console.WriteLine();
            for (int i = -2; i >= -8; i--)
            {
                float x = (float)Math.Pow(10, -1);
                Console.WriteLine($"Производная в точке 10^-1 с шагом 10^{i} равна {proizv(x + (float)Math.Pow(10, i), x)}");
            }
            Console.WriteLine();
            for (int i = -2; i >= -8; i--)
            {
                float x = 1;
                Console.WriteLine($"Производная в точке 1 с шагом 10^{i} равна {proizv(x + (float)Math.Pow(10, i), x)}");
            }
            Console.WriteLine();
            for (int i = -2; i >= -8; i--)
            {
                float x = 10;
                Console.WriteLine($"Производная в точке 10 с шагом 10^{i} равна {proizv(x + (float)Math.Pow(10, i), x)}");
            }
            Console.WriteLine();
            for (int i = -2; i >= -8; i--)
            {
                float x = (float)Math.Pow(10, 2);
                Console.WriteLine($"Производная в точке 10^2 с шагом 10^{i} равна {proizv(x + (float)Math.Pow(10, i), x)}");
            }
        }
    }
}
