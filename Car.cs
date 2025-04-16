using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_2
{
    internal class Car : Vehicle
    {
        int passengers;

        public int Passengers { get => passengers; set => passengers = value; }

        public Car(double x, double y, int price, int speed,
            int manufacturerYear, int passengers) : base(x, y, price, speed, manufacturerYear)
        {
            Passengers = passengers;
        }

        public static Car Input()
        {
            Console.WriteLine("Создание автомобиляСан.");
            Console.Write("Координата X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Координата Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Скорость: ");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Год выпуска: ");
            int manufacturerYear = int.Parse(Console.ReadLine());
            Console.Write("Пассажиры: ");
            int passengers = int.Parse(Console.ReadLine());
            return new Car(x, y, price, speed, manufacturerYear, passengers);
        }

        public override string ToString()
        {
            return base.ToString() + $", Количество пассажиров: {Passengers}";
        }
    }
}
