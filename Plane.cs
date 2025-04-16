using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_2
{
    internal class Plane : Vehicle
    {
        int height;
        int passengers;

        public int Height { get => height; set => height = value; }
        public int Passengers { get => passengers; set => passengers = value; }

        public Plane(double x, double y, int price, int speed, 
            int manufacturerYear, int height, int passengers) : base(x, y, price, speed, manufacturerYear)
        {
            Height = height;
            Passengers = passengers;
        }

        public static Plane Input()
        {
            Console.WriteLine("Создание корабля.");
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
            Console.Write("Высота: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Пассажиры: ");
            int passengers = int.Parse(Console.ReadLine());
            return new Plane(x, y, price, speed, manufacturerYear, height, passengers);
        }

        public override string ToString()
        {
            return base.ToString() + $", Высота: {Height}, Количество пассажиров: {Passengers}";
        }
    }
}
