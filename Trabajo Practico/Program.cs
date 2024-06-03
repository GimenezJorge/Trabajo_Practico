using System;
using Trabajo_Practico.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("______________________ PERSONA: ______________________\n");
        Persona persona1 = new Persona("Jorge", 41, "hombre");
        persona1.hablar();

        Console.WriteLine("\n\n______________________ BARCO: ________________________\n");
        Barco barco1 = new Barco(50, 25);
        int pesoNeto = barco1.valeLaPenaSaquear();
        if (pesoNeto > 20)
        {
            Console.WriteLine($"SI Vale la pena saquear este barco (cargamento: {pesoNeto})");
        }
        else
        {
            Console.WriteLine($"NO Vale la pena saquear este barco (cargamento: {pesoNeto})");
        }
        Console.WriteLine("\n\n______________________ TANQUE: _______________________\n");        

        Tanque tanque1 = new Tanque("TanqueBueno", "Argentina", 1982, 50, new List<string> { "USA", "Canada", "Mexico" });
        Tanque tanque2 = new Tanque("TanqueMalo", "Alemania", 1980, 30, new List<string> { "Rusia", "China","Inglaterra" });

        tanque1.batalla(tanque2);

        Console.WriteLine("\n\n______________________ BLOQUE: _______________________\n");
        Bloque bloque1 = new Bloque(20, 10, 15);
        int largo = bloque1.obtenerLargo();
        int ancho = bloque1.obtenerAncho();
        int alto = bloque1.obtenerAlto();
        int volumen = bloque1.obtenerVolumen();
        int areaSuperficie = bloque1.obtenerAreaSuperficie();

        Console.WriteLine($"El bloque tiene {largo} cm de largo");
        Console.WriteLine($"El bloque tiene {ancho} cm de ancho");
        Console.WriteLine($"El bloque tiene {alto} cm de alto");
        Console.WriteLine($"El bloque tiene un volumen de {volumen} cm³");
        Console.WriteLine($"El bloque tiene un area de {areaSuperficie} cm²");
        
        Console.WriteLine("\n\n_______________________________________________________\n");
    }
}