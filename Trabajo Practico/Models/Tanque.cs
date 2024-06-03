using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Models
{
    public class Tanque
    {
        public string nombre { get; set; }
        public string pais { get; set; }
        public int año { get; set; }
        public int peso { get; set; }
        public List<string> aliados { get; set; }

        public Tanque(string nombre, string pais, int año, int peso, List<string> aliados)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.año = año;
            this.peso = peso;
            this.aliados = aliados;
        }

        public void mostrarInfoGanador(Tanque tanqueGanador)
        {
            Console.WriteLine($"GANADOR: {tanqueGanador.nombre}");
            Console.WriteLine($"PAIS:    {tanqueGanador.pais}");
            Console.WriteLine($"AÑO:     {tanqueGanador.año}");
            Console.WriteLine($"PESO:    {tanqueGanador.peso} toneladas");

            Console.WriteLine("ALIADOS:");
            foreach (string elemento in tanqueGanador.aliados)
            {
                Console.WriteLine($"         {elemento}");
            }
        }

        public void batalla(Tanque tanqueRival)
        {
            if (this.año > tanqueRival.año)
            {
                mostrarInfoGanador(this);
            }

            if (this.año < tanqueRival.año)
            {
                mostrarInfoGanador(tanqueRival);
            }

            if (this.año == tanqueRival.año)
            {
                if (this.peso > tanqueRival.peso)
                {
                    mostrarInfoGanador(this);
                }

                if (this.peso < tanqueRival.peso)
                {
                    mostrarInfoGanador(tanqueRival);
                }

                if (this.peso == tanqueRival.peso)
                {
                    Console.WriteLine("EMPATE");
                }
            }
        }


    }
}