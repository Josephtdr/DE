using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods__DE_ {
    class Program {
        static void Main(string[] args) {
            Eulers_Step_Method(1,0,0.01m,1.2m,jprime, true);
            Console.ReadKey();
        }

        static decimal fprime(decimal x, decimal y) {
            return (decimal)(2 * Math.Pow((double)x,3));
        }

        static decimal gprime(decimal x, decimal y) {
            return (decimal)(Math.Pow(Math.E, (double)x) + (3 * Math.Sin((double)y)));
        }
        
        static decimal hprime(decimal x, decimal y) {
            return (((decimal)Math.Cos((double)x) - (3 * x * (y + (0.1m * y * y)))) / (x * x));
        }

        static decimal jprime(decimal x, decimal y) {
            return ((1/x)*(decimal)(Math.Sin((double)y))+1);
        }
        static void Eulers_Step_Method(decimal x, decimal y, decimal h, decimal desired_x, Func<decimal, decimal, decimal> FPRIME, bool PrintALL) {
            int steps = (int)((desired_x - x) / h);
            Console.WriteLine("h={0}",h);
            Console.WriteLine("At x={0}, y={1}", x, y);
            for (int i = 0; i < steps; i++) {
                y += FPRIME(x, y) * h;
                x += h;
                if(PrintALL)
                    Console.WriteLine("At x={0}, y={1}", x, y);
            }
            if(!PrintALL)
                Console.WriteLine("At x={0}, y={1}", x, y);
        }
    }
}
