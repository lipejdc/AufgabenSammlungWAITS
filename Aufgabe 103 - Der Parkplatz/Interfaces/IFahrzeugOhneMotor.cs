﻿using Aufgabe_103___Der_Parkplatz.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_103___Der_Parkplatz
{
    public interface IFahrzeugOhneMotor
    {
        Fahrzeugart Typ { get; set; }
        Colors Farbe { get; set; }
        int Länge { get; set; }
        int Breite { get; set; }
    }
}
