using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_103___Der_Parkplatz.Classes
{
    public class Fahrzeug : IFahrzeugOhneMotor, IFahrzeugMitMotor, IFahrzeugZusatz
    {
        public Fahrzeug(Fahrzeugart typ, Colors farbe, int länge, int breite, int hubraum, int leistung, int drehmoment, 
            double beschleunigung0_100, int höchstgeschwindigkeit, int zuladung)
        {
            Typ = typ;
            Farbe = farbe;
            Länge = länge;
            Breite = breite;
            Hubraum = hubraum;
            Leistung = leistung;
            Drehmoment = drehmoment;
            Beschleunigung0_100 = beschleunigung0_100;
            Höchstgeschwindigkeit = höchstgeschwindigkeit;
            Zuladung = zuladung;
        }

        public Fahrzeug(Colors farbe)
        {
            Farbe = farbe;
        }

        //Eigenschaften FahrzeugOhneMotor
        public Fahrzeugart Typ { get; set; }
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
