using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class taskInterface
    {
           public interface IVehiculo
            {
                void Drive();
                bool Refuel(int amount);
            }

            public class Car : IVehiculo
            {
            public int Gasloine;

                public Car(int gasloine)
                {
                Gasloine = gasloine;
                }

                public void Drive()
                {
                    if (Gasloine > 0)
                    {
                        Console.WriteLine("Driving");
                    }
                    else
                    {
                        Console.WriteLine("Not Driving");
                    }
                }

                public bool Refuel(int amount)
                {
                Gasloine =Gasloine + amount;
                    return true;
                }
            public static void Main(string[] args)
            {
                Car car = new Car(0);

                int gasloine = Convert.ToInt32(Console.ReadLine());
                if (car.Refuel(gasloine))
                {
                    car.Drive();
                }
            }
        }
        
    }
}
