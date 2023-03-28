
using Ejercicio_IMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonasModel.DAL
{
    public class PersonasDAL
    {
        //1. Crear una lista para guardar personas
        private static List<Persona> personas = new List<Persona>();

        //2. Crear las operaciones ingresar, mostrar y buscar
        public void AgregarPersona(Persona p)
        {
            personas.Add(p);
        }
        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            List<Persona> filtrada = new List<Persona>();
            for (int i = 0; i < personas.Count(); i++)
            {
                if (personas[i].Nombre == nombre)
                {
                    filtrada.Add(personas[i]);
                }
            }
            return filtrada;

        }




    }
}
