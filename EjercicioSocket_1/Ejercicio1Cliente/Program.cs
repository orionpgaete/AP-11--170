using ClienteSocketUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Cliente
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese servidor");
            string servidor = Console.ReadLine().Trim();
            int puerto;
            do
            {
                Console.WriteLine("Ingrese puerto");

            } while (!Int32.TryParse(Console.ReadLine().Trim(), out puerto));

            Console.WriteLine("Conectando...");
            ClienteSocket clienteSocket = new ClienteSocket(servidor, puerto);

            if (clienteSocket.Conectar())
            {
                GenerarComunicacion(clienteSocket);
            } else
            {
                Console.WriteLine("Error de comunicacion");
            }
            Console.ReadKey();
        }

        static void GenerarComunicacion(ClienteSocket clienteSocket)
        {
            bool terminar = false;
            while (!terminar)
            {
                Console.WriteLine("En que le podemos ayudar.. : ");
                string mensaje = Console.ReadLine().Trim();
                clienteSocket.Escribir(mensaje);
                if (mensaje.ToLower() == "chao")
                {
                    terminar = true;    
                } else
                {
                    mensaje = clienteSocket.Leer();
                    if (mensaje != null)
                    {
                        Console.WriteLine("Cli: {0}", mensaje);
                        if (mensaje.ToLower() == "chao")
                        {
                            terminar = true;
                        }
                    }else
                    {
                        terminar = true;
                    }
                    
                }
            }
        }

    }

   
}
