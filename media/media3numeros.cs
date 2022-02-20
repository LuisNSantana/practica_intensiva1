using System;

namespace media
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el primer numero: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar el segundo numero: ");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar el tercer numero: ");

            int num3 = Convert.ToInt32(Console.ReadLine());

            Double media = (num1 + num2 + num3) / 3;

            Console.WriteLine("La media es: " + media);
        }
    }
}
