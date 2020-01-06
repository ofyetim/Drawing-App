using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace G161210309__OmerfarukYetim
{
   sealed class Dortgen:Cokgen
    {
        public override void ciz(Graphics cizimAraci, SolidBrush _brush, int x, int y)
        {
            Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, BaslangicY), new Point(x, y), new Point(BaslangicX, y) };
            GraphicsPath dortgen = new GraphicsPath();
            dortgen.AddPolygon(sinir);
            cizimAraci.FillPath(_brush, dortgen);
            SonX = x;
            SonY = y;
        }
        public override bool Sec(Graphics cizimAraci, Pen _brush, int x, int y)
        {
            if (x >= BaslangicX && x <= SonX && y >= BaslangicY && y <= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY - 4), new Point(SonX, BaslangicY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX + 4, BaslangicY), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY + 4), new Point(BaslangicX, SonY + 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - 4, SonY), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x <= BaslangicX && x >= SonX && y <= BaslangicY && y >= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + 4, BaslangicY), new Point(BaslangicX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, SonY - 4), new Point(SonX, SonY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX - 4, BaslangicY), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, BaslangicY + 4), new Point(BaslangicX, BaslangicY + 4));
                return true;
            }
            else if (x >= BaslangicX && x <= SonX && y <= BaslangicY && y >= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - 4, BaslangicY), new Point(BaslangicX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, SonY - 4), new Point(SonX, SonY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX + 4, BaslangicY), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, BaslangicY + 4), new Point(BaslangicX, BaslangicY + 4));
                return true;
            }
            else if (x <= BaslangicX && x >= SonX && y >= BaslangicY && y <= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + 4, BaslangicY), new Point(BaslangicX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, SonY + 4), new Point(SonX, SonY + 4));
                cizimAraci.DrawLine(_brush, new Point(SonX - 4, BaslangicY), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, BaslangicY - 4), new Point(BaslangicX, BaslangicY - 4));
                return true;
            }
            return false;
        }
    }
}
