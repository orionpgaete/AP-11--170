using Proyecto_2.Comunicacion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);

            Console.WriteLine("Iniciando Servidor en puerto {0}", puerto);
            ServerSocket servidor = new ServerSocket(puerto);

            if (servidor.Iniciar())
            {
                //OK, puede conectar
                Console.WriteLine("Servidor iniciado");

                //Solicitiando clientes infinitamente
                while (true)
                {
                    Console.WriteLine("Esperando Cliente...");
                    Socket socketCliente = servidor.ObtenerCliente();

                    //construir el mecanismo para escribir y leeer cliente
                    ClienteCom cliente = new ClienteCom(socketCliente);
                    //aqui esta el protocolo de comunicacion
                    cliente.Escribir("Hola mundo cliente, dime tu nombre: ");
                    string respuesta = cliente.Leer();
                    Console.WriteLine("El cliente envio: {0}", respuesta);
                    cliente.Escribir("Chaaoo los vimos");
                    cliente.Desconectar();

                }
                
            }
            else
            {
                Console.WriteLine("ERRRORR!!!, el puerto {0} esta en uso", puerto);
            }
        }
    }
}
