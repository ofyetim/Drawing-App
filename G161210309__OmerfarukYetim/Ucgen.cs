using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace G161210309__OmerfarukYetim
{
    sealed class Ucgen : Cokgen
    {


        public override void ciz(Graphics cizimAraci, SolidBrush f, int x, int y)
        {
            if ((BaslangicX - x + BaslangicX <= 1000) && (BaslangicX - x + BaslangicX >= 0)) 
            {
                Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, y), new Point(BaslangicX - x + BaslangicX, y) };
                GraphicsPath ucgen = new GraphicsPath();
                ucgen.AddPolygon(sinir);
                cizimAraci.FillPath(f, ucgen);
                SonX = x;
                SonY = y;
            }
            else
            {
                if (BaslangicX - x + BaslangicX > 956) 
                {
                    x = (2 * BaslangicX) - 956;
                    Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, y), new Point(BaslangicX - x + BaslangicX, y) };
                    GraphicsPath ucgen = new GraphicsPath();
                    ucgen.AddPolygon(sinir);
                    cizimAraci.FillPath(f, ucgen);
                    SonX = x;
                    SonY = y;
                }
                else if (BaslangicX - x + BaslangicX < 0) 
                {
                    x = 2 * BaslangicX;
                    Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, y), new Point(BaslangicX - x + BaslangicX, y) };
                    GraphicsPath ucgen = new GraphicsPath();
                    ucgen.AddPolygon(sinir);
                    cizimAraci.FillPath(f, ucgen);
                    SonX = x;
                    SonY = y;
                }
            }
        }

        public override bool Sec(Graphics cizimAraci, Pen f, int x, int y)
        {
            if (x >= (BaslangicX - SonX + BaslangicX) && x <= SonX && y >= BaslangicY && y <= SonY)
            {
                cizimAraci.DrawLine(f, new Point(BaslangicX + 4, BaslangicY), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(f, new Point(SonX, SonY + 4), new Point(BaslangicX - SonX + BaslangicX, SonY + 4));
                cizimAraci.DrawLine(f, new Point(BaslangicX - SonX + BaslangicX - 4, SonY), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x <= (BaslangicX - SonX + BaslangicX) && x >= SonX && y >= SonY && y <= BaslangicY)
            {
                cizimAraci.DrawLine(f, new Point(BaslangicX - 4, BaslangicY), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(f, new Point(SonX, SonY - 4), new Point(BaslangicX - SonX + BaslangicX, SonY - 4));
                cizimAraci.DrawLine(f, new Point(BaslangicX - SonX + BaslangicX + 4, SonY), new Point(BaslangicX + 4, BaslangicY));
                return true;
            }
            else if (x <= SonX && x >= (BaslangicX - SonX + BaslangicX) && y <= BaslangicY && y >= SonY)
            {
                cizimAraci.DrawLine(f, new Point(BaslangicX + 4, BaslangicY), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(f, new Point(SonX, SonY + 4), new Point(BaslangicX - SonX + BaslangicX, SonY + 4));
                cizimAraci.DrawLine(f, new Point(BaslangicX - SonX + BaslangicX - 4, SonY), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x <= (BaslangicX - SonX + BaslangicX) && x >= SonX && y >= BaslangicY && y <= SonY)
            {
                cizimAraci.DrawLine(f, new Point(BaslangicX - 4, BaslangicY), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(f, new Point(SonX, SonY + 4), new Point(BaslangicX - SonX + BaslangicX, SonY + 4));
                cizimAraci.DrawLine(f, new Point(BaslangicX - SonX + BaslangicX + 4, SonY), new Point(BaslangicX + 4, BaslangicY));
                return true;
            }
            return false;
        }
    }
}
