using System;

namespace sueldo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("La primera venta que realizo: ");
            double venta1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La segunda venta que realizo: ");
            double venta2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La tercera venta que realizo: ");
            double venta3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cual es su sualde base: ");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());

           double resultado = ((venta1 * 10 / 100) + (venta2 * 10 / 100) + (venta3 * 10 / 100)) + sueldoBase;

            Console.WriteLine("Su sueldo total con comisiones + sueldo base es: " + resultado);

        }

       
    }
}
