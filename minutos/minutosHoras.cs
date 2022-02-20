using System;

namespace minutos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los minutos para saber cuantas horas son: ");

            int minutos = Convert.ToInt32(Console.ReadLine());

            float horas = minutos /60;

            float min = minutos % 60;

            Console.WriteLine("segun los minutos que ingreso, Son: " + horas + " horas " + min + " minutos ");
        }
    }
}
