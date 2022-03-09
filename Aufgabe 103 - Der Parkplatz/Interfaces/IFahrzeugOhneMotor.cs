using Aufgabe_103___Der_Parkplatz.Classes;

namespace Aufgabe_103___Der_Parkplatz;

public interface IFahrzeugOhneMotor
{
    Fahrzeugart Typ { get; set; }
    Colors Farbe { get; set; }
    int Länge { get; set; }
    int Breite { get; set; }

}
