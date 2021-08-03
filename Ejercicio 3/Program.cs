using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Oscar Mauricio Avalos Molina 
//Eliezer Benjamin Diaz Segovia 
namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el primer valor");
            int var1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valor");
            int var2 = Int32.Parse(Console.ReadLine());
            if (var2 != 0)
            {
                Console.WriteLine($"{var1 / var2}");
            }
            else
            {
                Console.WriteLine($"Error: No se puede dividir entre cero.");
            }
            Console.ReadKey();
        }
    }
}
