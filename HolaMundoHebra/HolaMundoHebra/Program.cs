using HolaMundoHebra.Hebra_Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaMundoHebra
{
    internal class Program
    {
        static void ejecutar()
        {
            int i = Convert.ToInt32(Thread.CurrentThread.Name);
            Thread.Sleep(i * 1000);
            Console.WriteLine("Hola desde {0}", i);
        }

        static void ejecutarconParametro(object o)
        {
            int i = (int)o;
            Thread.Sleep(i * 1000);
            Console.WriteLine("Hola Hebra parametro {0}", i);
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Iniciando Hebra");
            for (int i = 1; i < 7; i++)
            {
                // Thread t = new Thread(new ThreadStart(ejecutar));
                //Thread t = new Thread(new ParameterizedThreadStart(ejecutarconParametro));
                // t.Name = i.ToString();
                //t.Start(i);

                Hebra he = new Hebra(i);
                Thread t = new Thread(new ThreadStart(he.ejecutar));
                t.Start();

            }
            Console.WriteLine("iniciada");

            Console.ReadKey();
        }
    }
}
