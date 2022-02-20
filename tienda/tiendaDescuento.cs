using System;

namespace tienda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su compra: ");
            double compra = Convert.ToDouble(Console.ReadLine());

            double resultado = compra - (compra * 15 / 100);

            Console.WriteLine("Usted debera pagar finalmente: " + resultado);
        }
    }
}
