using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe102
{
    public class ZweiDPunkt
    {
        //Eigenschaften
        public int X { get; set; }
        public int Y { get; set; }

        //Konstruktor
        public ZweiDPunkt(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Objekte
        ZweiDPunkt ZweiD = new ZweiDPunkt(60, 100);
        ZweiDPunkt BallX = new ZweiDPunkt(0, 0);
        ZweiDPunkt BallY = new ZweiDPunkt(0, 0);
    }
}
