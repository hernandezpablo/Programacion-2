using System;

namespace Ejercicio_1
{
    internal class Program
    {
        /*Ingresar 5 números por consola, guardándolos en una variable escalar.
        Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;
            bool resultado;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero);
            } while (!resultado);

            Console.WriteLine("El numero ingresado fue {0}", numero);
        }
    }
}
