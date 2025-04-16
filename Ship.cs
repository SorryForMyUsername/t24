using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_2
{
    internal class Ship : Vehicle
    {
        int passengers;
        string port;

        public int Passengers { get => passengers; set => passengers = value; }
        public string Port { get => port; set => port = value; }

        public Ship(double x, double y, int price, int speed,
            int manufacturerYear, int passengers, string port) : base(x, y, price, speed, manufacturerYear)
        {
            Passengers = passengers;
            Port = port;
        }

        public static Ship Input()
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
            Console.Write("Пассажиры: ");
            int passengers = int.Parse(Console.ReadLine());
            Console.Write("Порт приписки: ");
            string port = Console.ReadLine();
            return new Ship(x, y, price, speed, manufacturerYear, passengers, port);
        }

        public override string ToString()
        {
            return base.ToString() + $", Количество пассажиров: {Passengers}, Порт приписки: {Port}";
        }
    }
}
