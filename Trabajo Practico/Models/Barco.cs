using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    public class Barco
    {
        public int cargamento { get; set; }
        public int tripulacion { get; set; }

        public Barco(int cargamento, int tripulacion)
        {
            this.cargamento = cargamento;
            this.tripulacion = tripulacion;
        }

        public int valeLaPenaSaquear()
        {
            int pesoNeto = this.cargamento - this.tripulacion;
            return pesoNeto;
        }
    }
}
