using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IMC
{
    public partial class Program
    {
        static PersonasDAL personasDAL = new PersonasDAL();
        static void MostrarPersona()
        {
            List<Persona> personas = personasDAL.ObtenerPersonas();
            for(int i = 0; i < personas.Count; i++)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0}: Nombre: {1} Peso: {2}", i, actual.Nombre, actual.Peso);
            }
        }

        static void BuscarPersona()
        {
            Console.WriteLine("Ingrese nombre");
            new PersonasDAL().FiltrarPersonas(Console.ReadLine().Trim())
                             .ForEach(p => Console.WriteLine("Nombre: {0} Peso:{1}", p.Nombre, p.Peso));
            List<Persona> personas = new PersonasDAL().FiltrarPersonas(Console.ReadLine().Trim());
            foreach(Persona p in personas) 
            {
                Console.WriteLine("Nombre: {0} Peso{1}", p.Nombre, p.Peso);
            }
        }

        static void IngresarPersona()
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

            /*Persona p = new Persona();
            p.Nombre = nombre;
            p.Estatura = estatura;
            p.Peso = peso; 
            p.Telefono  = telefono; */

            Persona p = new Persona() { 
                                        Nombre = nombre,
                                        Estatura  = estatura,
                                        Telefono = telefono,
                                        Peso = peso
                                      };
            personasDAL.AgregarPersona(p);
                   
            Console.WriteLine("Nombre : {0} ", p.Nombre);
            Console.WriteLine("Telefono : {0} ", p.Telefono);
            Console.WriteLine("Peso : {0} ", p.Peso);
            Console.WriteLine("Estatura : {0} ", p.Estatura);
            Console.WriteLine("Su IMC : {0} ", peso / (estatura * estatura));
            Console.ReadKey();

        }
    }
}
