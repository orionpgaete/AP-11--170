using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaMundoHebra.Hebra_Clase
{
    public class Hebra
    {
        private int num;

        public Hebra(int n)
        {
            this.num = n;
        }

        public void ejecutar()
        {
            Thread.Sleep(this.num * 1000);
            Console.WriteLine("Hola desde {0}", num);
        }
    }
}
