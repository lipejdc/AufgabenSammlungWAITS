using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_103___Der_Parkplatz.Classes
{
    public class Fahrzeug : IFahrzeugOhneMotor, IFahrzeugMitMotor, IFahrzeugZusatz
    {
        //Konstruktor
        public Fahrzeug(Fahrzeugart typ)
        {
            Typ = typ;
            SetDefaultVehicleValues();
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
        public double Zuladung { get; set; }

        private string _ausgabe;

        public override string ToString()
        {
            return _ausgabe;
        }

        //Methoden für die Erzeugung von Zufallswerten (Integer und Double)
        public static int GenerateRandomIntegerValue(int min, int max)
        {
            var rdn = new Random();
            return rdn.Next(min, max);
        }

        public static double GenerateRandomDoubleValue(double min, double max)
        {
            var rnd = new Random();
            var roundDouble = rnd.NextDouble() * (max - min) + min;

            return Math.Round(roundDouble, 2);
        }

        //Methode für die Fallunterscheidung von Fahrzeugarten und die Zuweisung deren Eigenschaften
        public void SetDefaultVehicleValues()
        {
            if (Typ == Fahrzeugart.Fahrrad)
            {
                Farbe = new Colors("red");
                Länge = GenerateRandomIntegerValue(150, 201);
                Breite = GenerateRandomIntegerValue(60, 71);
                _ausgabe = $"FAHRRAD: \n" +
                           $"Farbe: {Farbe.Farbe} \n" +
                           $"Länge: {Länge} \n" +
                           $"Breite: {Breite}";
            }

            else if (Typ == Fahrzeugart.Motorrad)
            {
                Farbe = new Colors("blue");
                Länge = GenerateRandomIntegerValue(150, 191);
                Breite = GenerateRandomIntegerValue(60, 81);
                Hubraum = GenerateRandomIntegerValue(50, 1401);
                Leistung = GenerateRandomIntegerValue(2, 163);
                Drehmoment = GenerateRandomIntegerValue(5, 201);
                Beschleunigung0_100 = GenerateRandomDoubleValue(7.6, 2.4);
                Höchstgeschwindigkeit = GenerateRandomIntegerValue(25, 301);
                Zuladung = GenerateRandomDoubleValue(0, 0.271);
                _ausgabe = $"MOTORRAD: \n" +
                           $"Farbe: {Farbe.Farbe} \n" +
                           $"Länge: {Länge} \n" +
                           $"Breite: {Breite} \n" +
                           $"Hubraum: {Hubraum} \n" +
                           $"Leistung: {Leistung} \n" +
                           $"Drehmoment {Drehmoment} \n" +
                           $"Beschleunigung0_100: {Beschleunigung0_100} \n" +
                           $"Höchstgeschwindigkeit: {Höchstgeschwindigkeit} \n" +
                           $"Zuladung: {Zuladung}";
            }

            else if (Typ == Fahrzeugart.Auto)
            {
                Farbe = new Colors("yellow");
                Länge = GenerateRandomIntegerValue(250, 618);
                Breite = GenerateRandomIntegerValue(160, 186);
                Hubraum = GenerateRandomIntegerValue(49, 84001);
                Leistung = GenerateRandomIntegerValue(44, 3825);
                Drehmoment = GenerateRandomIntegerValue(90, 1500);
                Beschleunigung0_100 = GenerateRandomDoubleValue(16.0, 1.7);
                Höchstgeschwindigkeit = GenerateRandomIntegerValue(80, 509);
                Zuladung = GenerateRandomDoubleValue(0, 0.55);
                _ausgabe = $"AUTO: \n" +
                           $"Farbe: {Farbe.Farbe} \n" +
                           $"Länge: {Länge} \n" +
                           $"Breite: {Breite} \n" +
                           $"Hubraum: {Hubraum} \n" +
                           $"Leistung: {Leistung} \n" +
                           $"Drehmoment {Drehmoment} \n" +
                           $"Beschleunigung0_100: {Beschleunigung0_100} \n" +
                           $"Höchstgeschwindigkeit: {Höchstgeschwindigkeit} \n" +
                           $"Zuladung: {Zuladung}";
            }

            else
            {
                Farbe = new Colors("white");
                Länge = GenerateRandomIntegerValue(320, 5000);
                Breite = GenerateRandomIntegerValue(204, 975);
                Hubraum = GenerateRandomIntegerValue(12800, 16400);
                Leistung = GenerateRandomIntegerValue(132, 1766);
                Drehmoment = GenerateRandomIntegerValue(1250, 3501);
                Beschleunigung0_100 = GenerateRandomDoubleValue(20.0, 4.6);
                Höchstgeschwindigkeit = GenerateRandomIntegerValue(60, 276);
                Zuladung = GenerateRandomDoubleValue(0, 25);
                _ausgabe = $"LKW: \n" +
                           $"Farbe: {Farbe.Farbe} \n" +
                           $"Länge: {Länge} \n" +
                           $"Breite: {Breite} \n" +
                           $"Hubraum: {Hubraum} \n" +
                           $"Leistung: {Leistung} \n" +
                           $"Drehmoment {Drehmoment} \n" +
                           $"Beschleunigung0_100: {Beschleunigung0_100} \n" +
                           $"Höchstgeschwindigkeit: {Höchstgeschwindigkeit} \n" +
                           $"Zuladung: {Zuladung}";
            }

        }

    }
}
