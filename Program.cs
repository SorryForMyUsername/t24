using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_2
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Добавить самолёт\n" +
                    "2. Добавить автомобиль\n" +
                    "3. Добавить корабль\n" +
                    "4. Вывести все транспортные средства\n" +
                    "5. Выход\n");

                int choice = Console.ReadKey(true).KeyChar - 48;

                switch (choice)
                {
                    case 1:
                        vehicles.Add(Plane.Input());
                        break;
                    case 2:
                        vehicles.Add(Car.Input());
                        break;
                    case 3:
                        vehicles.Add(Ship.Input());
                        break;
                    case 4:
                        Output();
                        break;
                    case 5: return;
                }

                Console.WriteLine();
            }
        }

        static void Output()
        {
            foreach(Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}
