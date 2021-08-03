using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Oscar Mauricio Avalos Molina 
//Eliezer Benjamin Diaz Segovia 
namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nota ('30%')");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu nota ('35%')");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu nota ('25%')");
            int not3 = Convert.ToInt32(Console.ReadLine());
            double rnot1 = not1 * 0.30;
            double rnot2 = not2 * 0.35;
            double rnot3 = not3 * 0.25;
            Console.WriteLine(
                $"Nota 1: {rnot1}\nNota 2: {rnot2}\nNota 3: {rnot3}"
                );
            Console.WriteLine($"Nota Final: {rnot1 + rnot2 + rnot3}");
            Console.ReadKey();
        }
    }
}
