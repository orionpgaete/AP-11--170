using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public class AsistentesDALDB : IAsistentesDAL
    {
        private EventosDBEntities eventoDB = new EventosDBEntities();
        public void AgregarAsistente(Asistente asistente)
        {
            this.eventoDB.Asistentes.Add(asistente);
            this.eventoDB.SaveChanges();
        }

        public void EliminarAsistente(int id)
        {
            //buscar el Asistente asociado al ID
            Asistente asistente = this.eventoDB.Asistentes.Find(id);
            //destruir asistente
            this.eventoDB.Asistentes.Remove(asistente);
            this.eventoDB.SaveChanges();
        }

        public Asistente Obtener(int id)
        {
            return this.eventoDB.Asistentes.Find(id);
        }

        public List<Asistente> ObtenerAsistentes()
        {
            return this.eventoDB.Asistentes.ToList();
        }

        public void Actualizar(Asistente a)
        {
            Asistente aOriginal = this.eventoDB.Asistentes.Find(a.Id);
            aOriginal.Nombre = a.Nombre;
            aOriginal.Apellido = a.Apellido;
            aOriginal.Edad = a.Edad;
            this.eventoDB.SaveChanges();
        }

        public List<Asistente> ObtenerAsistentes(string estado)
        {
            //LINQ
            var query = from a in this.eventoDB.Asistentes
                        where a.Estado == estado
                        select a;
            return query.ToList();
        }
    }
}


/// PRINCIPAL.MASTER -> BOOSTRAP
/// DEFAULT.ASPX
/// AGREGARASISTENTE.ASPX
/// MOSTRARASISTENTE.ASPX