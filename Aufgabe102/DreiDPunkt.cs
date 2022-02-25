using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe102
{
    public class DreiDPunkt : ZweiDPunkt
    {
        public int Z { get; set; }

        public DreiDPunkt(int x, int y, int z) : base(x, y)
        {
            
        }

        DreiDPunkt DreiD1 = new DreiDPunkt(80, 90, 100);
        DreiDPunkt DreiD2 = new DreiDPunkt(ZweiDPunkt, 50);
        DreiDPunkt BallZ = new DreiDPunkt(0, 0, 0);
    }
}
