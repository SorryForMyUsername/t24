using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_2
{
    abstract class Vehicle
    {
        double x;
        double y;
        int price;
        int speed;
        int manufacturerYear;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int Price { get => price; set => price = value; }
        public int Speed { get => speed; set => speed = value; }
        public int ManufacturerYear { get => manufacturerYear; set => manufacturerYear = value; }

        public Vehicle(double x, double y, int price, int speed, int manufacturerYear)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            ManufacturerYear = manufacturerYear;
        }

        public override string ToString()
        {
            return $"Координаты: ({X:f2} {Y:f2}), Цена: {Price}, Скорость: {Speed}, " +
                $"Год выпуска: {ManufacturerYear}";
        }
    }
}
