using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe102;

public class Punkt2D
{
    //Eigenschaften
    public int X { get; set; }
    public int Y { get; set; }

    //Konstruktor
    public Punkt2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Überladung
    public Punkt2D(Punkt2D point2D)
    {
        X = point2D.X;
        Y = point2D.Y;
    }
}
