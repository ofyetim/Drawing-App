using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace G161210309__OmerfarukYetim
{
   abstract class Cokgen
    {
        private string ad;
        private int baslangicX;
        private int baslangicY;
        private int sonX = 0;
        private int sonY = 0;
        private System.Drawing.Color renk;

        public string Ad { get { return ad; } set { ad = value; } }
        public int BaslangicX { get { return baslangicX; } set { baslangicX = value; } }
        public int BaslangicY { get { return baslangicY; } set { baslangicY = value; } }
        public int SonX { get { return sonX; } set { sonX = value; } }
        public int SonY { get { return sonY; } set { sonY = value; } }
        public System.Drawing.Color Renk { get { return renk; } set { renk = value; } }

        public abstract void ciz(Graphics cizimAraci, SolidBrush _brush, int x, int y);
        public abstract bool Sec(Graphics cizimAraci, Pen _brush, int x, int y);

    }
}
