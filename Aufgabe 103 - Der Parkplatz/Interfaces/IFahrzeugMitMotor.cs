using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_103___Der_Parkplatz
{
    public interface IFahrzeugMitMotor
    {
        int Hubraum { get; set; }
        int Leistung { get; set; }
        int Drehmoment { get; set; }
        double Beschleunigung0_100 { get; set; }
        int Höchstgeschwindigkeit { get; set; }
    }
}
