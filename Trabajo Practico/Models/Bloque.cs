using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    public class Bloque
    {
        public int largo { get; set; }
        public int ancho{ get; set; }
        public int alto{ get; set; }
    

        public Bloque(int largo, int ancho, int alto)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }
        public int obtenerLargo()
        {
            return largo;
        }
        public int obtenerAncho()
        {
            return ancho;
        }
        public int obtenerAlto()
        {
            return alto;
        }
        public int obtenerVolumen()
        {
            return largo * ancho * alto;
        }
        public int obtenerAreaSuperficie()
        {
            int superficie1 = (largo * ancho) * 2;
            int superficie2 = (ancho * alto) * 2;
            int superficie3 = (alto * largo) * 2;
            int superficieTotal= superficie1 + superficie2 + superficie3;
            return superficieTotal;
        }
    }
}
