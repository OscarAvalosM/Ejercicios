using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Oscar Mauricio Avalos Molina 
//Eliezer Benjamin Diaz Segovia 
namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el nombre del producto");
            string producto = Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto");
            int precio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El producto es medicina? Si/No");
            string bolean = Console.ReadLine();
            if (String.Compare(bolean, "si", true) == 0)
            {
                double total = precio;
                Console.WriteLine($"El producto \"{producto}\" tiene un valor de:\nTotal: ${total}");
            }
            else
            {
                double total = precio + precio * 0.13;
                Console.WriteLine($"El producto \"{producto}\" tiene un valor de:\nTotal: ${total}");
              
                
          
            }
            Console.ReadKey();
        }
    }
}
