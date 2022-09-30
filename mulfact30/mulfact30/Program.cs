using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace mulfact30
{
    internal class Program
    {

        int f = 1, i, n;
        public void fact()
        {
            Console.WriteLine("enter the number to calculate factorial");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                f = f * i;

            }
            Console.WriteLine("the factorial is = " + f);
        }
        public void table()
        {
            int a;

            Console.WriteLine("enter the number to calculate tables");
            a = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("{0} x {1}={2}\n", a, j, a * j);
            }
        }
            static void Main(string[] args)
            {
                Program p = new Program();
                p.fact();
                p.table();
            }
        }
    }

