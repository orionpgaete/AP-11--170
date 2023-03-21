using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundito");
            Console.WriteLine("Ingrese nombre :");
            //esto es un scanner
            string nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es " + nombre);
            Console.ReadKey();
        }
    }
}
