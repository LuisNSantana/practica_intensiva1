using System;

namespace grados
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba los grados Fahrenheit que desea convertir a celcius: ");

            int gradosF = Convert.ToInt32(Console.ReadLine());

            int convertidor = (gradosF - 32) * 5 / 9;

            Console.WriteLine("Sus grados en celcius es: " + convertidor);

        }
    }
}
