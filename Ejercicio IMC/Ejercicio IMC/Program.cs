using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IMC
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;

            Console.WriteLine("Bievenido, programa ultramente distinto");
            bool esValido;
            
            do
            {
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(string.Empty));

            do
            {
                Console.WriteLine("Ingrese Telefono :");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese Peso :");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese Estatura :");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!esValido);

            Console.WriteLine("Nombre : {0} ", nombre);
            Console.WriteLine("Telefono : {0} ", telefono);
            Console.WriteLine("Peso : {0} ", peso);
            Console.WriteLine("Estatura : {0} ", estatura);
            Console.WriteLine("Su IMC : {0} ", peso/(estatura * estatura));
            Console.ReadKey();

        }
    }
}
