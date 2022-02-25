using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe101
{
    public class Parkhaus
    {
        public static void ParkHausMagic(Dictionary<string, string> stellPlätze, string[] helpArray)
        {

            Console.WriteLine("Stellplätze und Kennzeichen:");

            //Iteration über das Dict
            foreach (var dic in stellPlätze)
            {
                Console.WriteLine($"{dic.Key}: {dic.Value}");

            }

            Console.ReadKey();
            Console.WriteLine("----------------------");

            // Warteschlange in welche sich die Autos einreihen
            Queue<string> fila = new();

            // Über das Hilfsarray iterieren
            foreach (var key in helpArray)
            {
                // Kennzeichen im Dict identifizieren und Fhzg. fährt Richtung Schranke (Kennzeichen in Queue schreiben)
                fila.Enqueue(stellPlätze[key]);
                // Fahrzeug in die Schlange stellen und Stellplätze freigeben (leerer String)
                stellPlätze[key] = "";


                //Über das Dict iterieren und überprüfen, ob das Auto vom Stellplatz an die Schranke abgefahren ist
                AusgabeStellplätze(stellPlätze);

                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Anzahl der Autos an der Schranke: {fila.Count}");

                //Über die Queue iterieren, um die Kennzeichen-Reihenfolge abzubilden
                AusgabeQueue(fila);

                Console.ReadKey();
            }
        }

        private static void AusgabeStellplätze(Dictionary<string, string> stellPlätze)
        {
            foreach (var kvp in stellPlätze)
            {
                if (kvp.Value == "")
                {
                    Console.WriteLine($"Stellplatz: {kvp.Key}, Status: FREI!");
                }
                else
                {
                    Console.WriteLine($"Stellplatz: {kvp.Key}, Status ist BESETZT! (Fahrzeug: {kvp.Value})");
                }
            }
        }

        private static void AusgabeQueue(Queue<string> fila)
        {
            foreach (var fzg in fila)
            {
                Console.WriteLine($"Fahrzeug {fzg} steht an der Schranke!");
            }
        }
    }
}
