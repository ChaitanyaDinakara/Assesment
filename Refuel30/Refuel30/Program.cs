using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Refuel30
{
    public class car
    {
        public interface IVehicle
        {
            void Drive();
            bool Refuel(int amt);
        }
        public class car1 : IVehicle
        {
            public int Fuel { get; set; }

            public car1(int fuel)            {
                Fuel = fuel;
            }

            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("start driving");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }

            public bool Refuel(int amt)
            {
                Fuel = Fuel + amt;
                return true;
            }


            static void Main(string[] args)
            {
                car1 c1 = new car1(0);
                int fuel = int.Parse(Console.ReadLine());
                if (c1.Refuel(fuel))
                {
                    c1.Drive();
                }
            }
        }
    }
}