using Mensajero.Comunicacion;
using MensajeroModel.DAL;
using MensajeroModel.DTO;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mensajero
{
    public class Program
    {
        private static IMensajesDAL mensajesDAL = MensajesDALArchivos.GetInstancia();

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine(" 1. Ingresar \n 2. Mostrar \n 0.Salir");
            switch(Console.ReadLine().Trim())
            {
                case "1": Ingresar();
                    break;
                case "2": Mostrar();
                    break;
                case "0": continuar = false;
                    break;
                default: Console.WriteLine("Ingrese de Nuevo");
                    break;
            }
            return continuar;
        }

        static void IniciarServidor()
        {
          

        }
        static void Main(string[] args)
        {
            //1. Iniciar el Servidor Socket en el puerto 3000
            //2. el puerto tiene que ser configurable App.Config
            //3. cuando reciba un cliente, tiene que solicitar a ese cliente el nombre, texto y agregar
            //mensaje con el tipo TCP
            //IniciarServidor();
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.Start();
            //1. ¿como atender mas de un cliente a las vez?
            //2. ¿como evito que dos clientes ingresen al archivo a la vez?
            //3. ¿como evitar el bloqueo mutuo?
            while (Menu()) ;
        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese texto: ");
            string texto = Console.ReadLine().Trim();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "Aplicacion"
            };
            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
            }
            

        }

        static void Mostrar()
        {
            List<Mensaje> mensajes = null;
            lock (mensajesDAL)
            {
                mensajes = mensajesDAL.ObtenerMensajes();
            }    
                
            foreach(Mensaje mensaje in mensajes)
            {
                Console.WriteLine(mensaje);
            }

        }
    }
}
