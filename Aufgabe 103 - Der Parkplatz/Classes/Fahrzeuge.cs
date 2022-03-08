using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_103___Der_Parkplatz.Classes
{
    public class Fahrzeuge : IFahrzeugOhneMotor, IFahrzeugMitMotor, IFahrzeugZusatz
    {
        //Eigenschaften FahrzeugOhneMotor
        public Enum Typ { get; set; }
        public Colors Farbe { get; set; }
        public int Länge { get; set; }
        public int Breite { get; set; }

        //Eigenschaften FahrzeugMitMotor
        public int Hubraum { get; set; }
        public int Leistung { get; set; }
        public int Drehmoment { get; set; }
        public double Beschleunigung0_100 { get; set; }
        public int Höchstgeschwindigkeit { get; set; }

        //Eigenschaften FahrzeugZusatz
        public int Zuladung { get; set; }
    }
}
