using System;

namespace Point3DApp
{
    // Структура для точки в 3D-просторі
    public struct Point3D
    {
        // Координати X, Y, Z
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Конструктор для ініціалізації координат
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Перевантаження оператора + для додавання двох точок
        public static Point3D operator +(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        // Перевизначення методу ToString для зручного виведення
        public override string ToString()
        {
            return $"Point({X}, {Y}, {Z})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо дві точки у 3D-просторі
            Point3D point1 = new Point3D(1.0, 2.0, 3.0);
            Point3D point2 = new Point3D(4.0, 5.0, 6.0);

            // Додаємо дві точки
            Point3D result = point1 + point2;

            // Виводимо результати
            Console.WriteLine($"Point 1: {point1}");
            Console.WriteLine($"Point 2: {point2}");
            Console.WriteLine($"Sum of Point 1 and Point 2: {result}");
        }
    }
}

