using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public void hablar()
        {
            Console.WriteLine($"Me llamo {this.nombre}, me considero {this.genero} y tengo {this.edad} años.");
        }
       
    }
}
