using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    public class MensajesDALArchivos : IMensajesDAL
    {
        //implementar Singleton:
        //1. Contructor tiene que ser private
        private MensajesDALArchivos() { }

        //2. Debe poseer un atributo del mismo tipo de la clase y estatico
        private static MensajesDALArchivos instancia;
        //3. tener un metodo getIntance, que de vuelva una referencia al atributo
        public static IMensajesDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new MensajesDALArchivos();
            }
            return instancia;
        }
        //como vamos a hacer para que 2 hebras no accedan a la vez a este archivo?????


        private static string url = Directory.GetCurrentDirectory();
        private static string archivo = url + "/mensajes.txt";
        public void AgregarMensaje(Mensaje mensaje)
        {
            try
            {
                using(StreamWriter write = new StreamWriter(archivo, true))
                {
                    write.WriteLine(mensaje.Nombre +";"+ mensaje.Texto + ";" + mensaje.Tipo);
                    write.Flush();
                }
            }
            catch(Exception ex)
            {

            }
        }

        public List<Mensaje> ObtenerMensajes()
        {
            List<Mensaje> lista = new List<Mensaje>();
            try
            {
                using (StreamReader read = new StreamReader(archivo))
                {
                    string texto = "";
                    do
                    {
                        texto = read.ReadLine();
                        if(texto != null)
                        {
                            string[] arr = texto.Trim().Split(';');
                            Mensaje mensaje = new Mensaje()
                            {
                                Nombre = arr[0],
                                Texto = arr[1],
                                Tipo = arr[2]
                            };
                            lista.Add(mensaje);
                        }

                    } while (texto != null);
                }

            }catch(Exception ex)
            {
                lista = null;
            }
            return lista;
        }


    }
}
