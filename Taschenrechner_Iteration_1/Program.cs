using System;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.

            Console.Write("Bitte gibt den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel den Text in Ganzzahlen
            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            // Berechnung ausführen
            int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            // Ausgabe
            Console.WriteLine("Das Ergebnis lautet: {0}", summe);
            Console.ReadLine();
        }
    }

}
