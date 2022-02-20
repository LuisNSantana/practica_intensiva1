using System;

namespace calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el otro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;

            Console.WriteLine("La operacion de cada numero es la siguiente: " +
                "\n Suma: " + suma + "\n Resta: " + resta + "\n Multiplicacion: " + multiplicacion
                + "\n Division: " + division);
        }
    }
}
