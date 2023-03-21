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
            //Console.WriteLine("Su nombre es " + nombre);
            int edad = -1;
            Console.WriteLine("Ingrese la edad :");
            string edadTx = Console.ReadLine().Trim();
            bool esValido = Int32.TryParse(edadTx, out edad);
            if (!esValido)
            {
                Console.WriteLine("Ingrese bien la edad");
            }
            else
            {
                Console.WriteLine("Su nombre es {0} y la edad es {1}", nombre, edad);
            }

            /*
             * string num = "12";
             * int num2;
             * bool esValido = int.TryParse(num, out num2);
             * 
             * es lo mismo que:
             * 
             * try{
             *      num2=int.Parse(num);
             *      return true;
             * }catch(Exception ex){
             *      return false;
             *      }
             */







            // TRIM = '    32   ' => '32'
            // TRIMSTART = '    32    ' => '32    '
            // TRIMEND = '   32   ' => '   32'

           /* try
            {
                int edad2 = Convert.ToInt32(edadTx);
            }catch (Exception ex)
            {

            }*/
            

            
            Console.ReadKey();
        }
    }
}
