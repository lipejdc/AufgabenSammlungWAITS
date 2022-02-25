using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Aufgabe102
{
    public class Ball
    {
        //Eigenschaften
        public Farben Farbe { get; set; }
        public DreiDPunkt Position { get; set; }

        //Objekt
        Ball Ball1 = new Ball(1, 80, 90, 100);

        //Konstruktor
        public Ball(Farben farbe, DreiDPunkt position)
        {
            Farbe = farbe;
            Position = position;
        }

        //Methoden
        //public int AddVector(int x, int y, int z)
        //{

        //}

        //public int AddVector(DreiDPunkt)
        //{

        //}

        //public int SetPosition(int x, int y, int z)
        //{

        //}

        //public int SetPosition(DreiDPunkt)
        //{

        //}

        //public string SetColor(Farben farbe)
        //{

        //}
    }
}
