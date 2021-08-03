using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Oscar Mauricio Avalos Molina 
//Eliezer Benjamin Diaz Segovia 
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a;
            int b;

            Console.WriteLine("Ingresa el valor A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el valor B");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = (a + b)*(a - b);
            int sum2 = a*2 - b;
            Console.WriteLine("El resultado de la primera operación es: " + sum);
            Console.WriteLine("El resultado de la segunda operación es: " + sum2);
            Console.ReadKey();
        }
    }
}
