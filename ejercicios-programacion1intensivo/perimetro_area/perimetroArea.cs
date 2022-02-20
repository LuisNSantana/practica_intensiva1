using System;
namespace ejerciciosprogramacion1intensivo.perimetro_area
{
    public class perimetroArea
    {
        public static void Mainn(string[] args)
        {
            Console.WriteLine("Inserte la base de su rectangulo");

			double Base= Convert.ToDouble(Console.ReadLine());


			Console.WriteLine("Inserte el numero del area");

			double Altura = Convert.ToDouble(Console.ReadLine());

			double area = Altura * Base;
			double perimetro = (Altura * 2) + (Base * 2);

			Console.WriteLine("El area del rectangulo es: " + area + "El perimetro del rectangulo es: " + perimetro
				);


            

    
        }
    }
}
