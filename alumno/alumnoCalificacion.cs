using System;

namespace alumno
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la calificacion de su primer parcial: ");
            double parcial1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de su segundo parcial: ");
            double parcial2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de su tercer parcial: ");
            double parcial3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de su Examen final : ");
            double ExamenFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de un trabajo final : ");
            double trabajofinal = Convert.ToDouble(Console.ReadLine());

            double resultadoParciales = (parcial1 + parcial2 + parcial3) / 3;

            double resultado = (resultadoParciales * 55 / 100) + (ExamenFinal * 30 / 100) + (trabajofinal * 15 / 100);

            Console.WriteLine("La nota del alumno es: " + resultado);
        }
    }
}
