using System;
namespace ejerciciosprogramacion1intensivo.catetos
{
    public struct catetosHipotenusa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba un cateto del triangulo rectangulo: ");
            double cateto1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el otro cateto: ");
            double cateto2 = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Sqrt((cateto1 * cateto1 + cateto2 * cateto2));
            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
