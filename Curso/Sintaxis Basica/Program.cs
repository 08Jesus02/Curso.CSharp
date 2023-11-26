using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Introduce el radio del circulo:");
            double diametro = double.Parse(Console.ReadLine());

            double radio = diametro / 2;
            //double Area = PI * radio * radio;
            double Area = Math.Pow(radio, 2)*PI;
            Console.WriteLine($"El Area es del circulo es: {Area}");
            
        }
    }
}
