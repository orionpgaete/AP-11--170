using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSocket_1
{
   
    public class Program
    {
        static void GenerarComunicacion(ClienteCom clienteCom)
        {
            bool terminar = false;
            while (!terminar)
            {
                string mensaje = clienteCom.Leer();
                if (mensaje != null)
                {
                    Console.WriteLine("Cli: {0}", mensaje);
                    if (mensaje.ToLower() == "chao")
                    {
                        terminar = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese respuesta : ");
                        mensaje = Console.ReadLine().Trim();
                        clienteCom.Escribir(mensaje);
                        if (mensaje.ToLower() == "chao")
                        {
                            terminar = true;
                        }
                    }
                }
                if (terminar)
                {
                    clienteCom.Desconectar();
                }
            }
        }
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("Iniciando servidor en puerto {0}", puerto);
            ServerSocket serverSocket = new ServerSocket(puerto);

            if (serverSocket.Iniciar())
            {
                while (true)
                {
                    Console.WriteLine("Esperando Clientes...");
                    Socket socket = serverSocket.ObtenerCliente();
                    Console.WriteLine("Cliente recibido");
                    //comunicarse con el cliente
                    ClienteCom clienteCom = new ClienteCom(socket);
                    GenerarComunicacion(clienteCom);
                }

            }
            else
            {
                Console.WriteLine("Error al comunicarse con el puerto {0}", puerto);
            }
        }
    }
}
