using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe102;

public class Punkt3D : Punkt2D
{
    //Eigenschaften
    public int Z { get; set; }

    //Konstruktoren
    public Punkt3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }

    public Punkt3D(Punkt2D point2D, int z) : base(point2D)
    {
        Z = z;
    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }
}
