using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IMC
{
    public class Persona
    {
        private string nombre;
        private uint telefono;
        private double estatura;
        private double peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public uint Telefono { get => telefono; set => telefono = value; }
        public double Estatura { get => estatura; set => estatura = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}
