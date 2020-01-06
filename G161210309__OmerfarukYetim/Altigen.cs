using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace G161210309__OmerfarukYetim
{
   sealed class Altigen:Cokgen
    {
        public override void ciz(Graphics cizimAraci, SolidBrush _brush, int x, int y)
        {

            if ((x + ((x - BaslangicX) / 2)) <= 956 && (x + ((x - BaslangicX) / 2)) >= 0 && (BaslangicX - ((x - BaslangicX) / 2)) <= 956 && (BaslangicX - ((x - BaslangicX) / 2)) >= 0)
            {
                Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, BaslangicY), new Point(x + ((x - BaslangicX) / 2), (y + BaslangicY) / 2), new Point(x, y), new Point(BaslangicX, y), new Point(BaslangicX - ((x - BaslangicX) / 2), (y + BaslangicY) / 2) };
                GraphicsPath altigen = new GraphicsPath();
                altigen.AddPolygon(sinir);
                cizimAraci.FillPath(_brush, altigen);
                SonX = x;
                SonY = y;
            }
            else 
            {
                if ((x + ((x - BaslangicX) / 2)) > 956) 
                {
                    x = (1396 + BaslangicX) / 3;
                    Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, BaslangicY), new Point(x + ((x - BaslangicX) / 2), (y + BaslangicY) / 2), new Point(x, y), new Point(BaslangicX, y), new Point(BaslangicX - ((x - BaslangicX) / 2), (y + BaslangicY) / 2) };
                    GraphicsPath altigen = new GraphicsPath();
                    altigen.AddPolygon(sinir);
                    cizimAraci.FillPath(_brush, altigen);
                    SonX = x;
                    SonY = y;
                }
                else if ((x + ((x - BaslangicX) / 2)) < 0)
                {
                    x = BaslangicX / 3;
                    Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, BaslangicY), new Point(x + ((x - BaslangicX) / 2), (y + BaslangicY) / 2), new Point(x, y), new Point(BaslangicX, y), new Point(BaslangicX - ((x - BaslangicX) / 2), (y + BaslangicY) / 2) };
                    GraphicsPath altigen = new GraphicsPath();
                    altigen.AddPolygon(sinir);
                    cizimAraci.FillPath(_brush, altigen);
                    SonX = x;
                    SonY = y;
                }
                else if ((BaslangicX - ((x - BaslangicX) / 2)) > 956)
                {
                    x = (3 * BaslangicX) - 1396;
                    Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, BaslangicY), new Point(x + ((x - BaslangicX) / 2), (y + BaslangicY) / 2), new Point(x, y), new Point(BaslangicX, y), new Point(BaslangicX - ((x - BaslangicX) / 2), (y + BaslangicY) / 2) };
                    GraphicsPath altigen = new GraphicsPath();
                    altigen.AddPolygon(sinir);
                    cizimAraci.FillPath(_brush, altigen);
                    SonX = x;
                    SonY = y;
                }
                else if ((BaslangicX - ((x - BaslangicX) / 2)) < 0)
                {
                    x = 3 * BaslangicX;
                    Point[] sinir = { new Point(BaslangicX, BaslangicY), new Point(x, BaslangicY), new Point(x + ((x - BaslangicX) / 2), (y + BaslangicY) / 2), new Point(x, y), new Point(BaslangicX, y), new Point(BaslangicX - ((x - BaslangicX) / 2), (y + BaslangicY) / 2) };
                    GraphicsPath altigen = new GraphicsPath();
                    altigen.AddPolygon(sinir);
                    cizimAraci.FillPath(_brush, altigen);
                    SonX = x;
                    SonY = y;
                }
            }

        }

        public override bool Sec(Graphics cizimAraci, Pen _brush, int x, int y)
        {
            if (x <= (SonX + ((SonX - BaslangicX) / 2)) && x >= BaslangicX - ((x - BaslangicX) / 2) && y <= SonY && y >= BaslangicY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY - 4), new Point(SonX, BaslangicY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX + 4, BaslangicY), new Point(SonX + ((SonX - BaslangicX) / 2) + 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point(SonX + ((SonX - BaslangicX) / 2) + 4, (BaslangicY + SonY) / 2), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY + 4), new Point(BaslangicX, SonY + 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - 4, SonY), new Point(BaslangicX - ((SonX - BaslangicX) / 2) - 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - ((SonX - BaslangicX) / 2) - 4, (BaslangicY + SonY) / 2), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x <= (BaslangicX + (BaslangicX - SonX) / 2) && x >= (SonX - (BaslangicX - SonX) / 2) && y >= SonY && y <= BaslangicY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY + 4), new Point(SonX, BaslangicY + 4));
                cizimAraci.DrawLine(_brush, new Point(SonX - 4, BaslangicY), new Point((SonX - (BaslangicX - SonX) / 2) - 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point((SonX - (BaslangicX - SonX) / 2) - 4, (BaslangicY + SonY) / 2), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY - 4), new Point(BaslangicX, SonY - 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + 4, SonY), new Point(BaslangicX + ((BaslangicX - SonX) / 2) + 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + ((BaslangicX - SonX) / 2) + 4, (BaslangicY + SonY) / 2), new Point(BaslangicX + 4, BaslangicY));
                return true;
            }
            else if (x <= (SonX + (SonX - BaslangicX) / 2) && x >= (BaslangicX - (SonX - BaslangicX) / 2) && y <= BaslangicY && y >= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY + 4), new Point(SonX, BaslangicY + 4));
                cizimAraci.DrawLine(_brush, new Point(SonX + 4, BaslangicY), new Point((SonX + (SonX - BaslangicX) / 2) + 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point((SonX + (SonX - BaslangicX) / 2) + 4, (BaslangicY + SonY) / 2), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY - 4), new Point(BaslangicX, SonY - 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - 4, SonY), new Point((BaslangicX - (SonX - BaslangicX) / 2) - 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point((BaslangicX - (SonX - BaslangicX) / 2) - 4, (BaslangicY + SonY) / 2), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x <= (BaslangicX + (BaslangicX - SonX) / 2) && x >= (SonX - (BaslangicX - SonX) / 2) && y <= SonY && y >= BaslangicY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY - 4), new Point(SonX, BaslangicY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX - 4, BaslangicY), new Point((SonX - (BaslangicX - SonX) / 2) - 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point((SonX - (BaslangicX - SonX) / 2) - 4, (BaslangicY + SonY) / 2), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY + 4), new Point(BaslangicX, SonY + 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + 4, SonY), new Point(BaslangicX + ((BaslangicX - SonX) / 2) + 4, (BaslangicY + SonY) / 2));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + ((BaslangicX - SonX) / 2) + 4, (BaslangicY + SonY) / 2), new Point(BaslangicX + 4, BaslangicY));
                return true;
            }
            return false;
        }
    }
}
