using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace G161210309__OmerfarukYetim
{
    sealed class Daire : Cokgen
    {
        private double cap;
        public double Cap { get { return cap; } set { cap = value; } }

        public override void ciz(Graphics cizimAraci, SolidBrush _brush, int x, int y)
        {
            Cap = (Math.Sqrt(Math.Pow(x - BaslangicX, 2.0) + Math.Pow(y - BaslangicY, 2.0)) / Math.Sqrt(2.0));
            if (BaslangicX <= x && BaslangicY <= y)
            {
                if (BaslangicX + (int)Cap <= 956)
                {
                    Rectangle daire = new Rectangle(BaslangicX, BaslangicY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                    SonX = BaslangicX + (int)Cap;
                    SonY = BaslangicY + (int)Cap;
                }
                else
                {
                    Cap = 698 - BaslangicX;
                    Rectangle daire = new Rectangle(BaslangicX, BaslangicY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                    SonX = BaslangicX + (int)Cap;
                    SonY = BaslangicY + (int)Cap;
                }
            }
            else if (BaslangicX >= x && BaslangicY >= y)
            {
                if (BaslangicX - (int)Cap >= 0)
                {
                    SonX = BaslangicX - (int)Cap;
                    SonY = BaslangicY - (int)Cap;
                    Rectangle daire = new Rectangle(SonX, SonY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                }
                else
                {
                    Cap = BaslangicX;
                    SonX = BaslangicX - (int)Cap;
                    SonY = BaslangicY - (int)Cap;
                    Rectangle daire = new Rectangle(SonX, SonY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                }
            }
            else if (BaslangicX <= x && BaslangicY >= y)
            {
                if (BaslangicX + (int)Cap <= 956)
                {
                    SonX = BaslangicX + (int)Cap;
                    SonY = BaslangicY - (int)Cap;
                    Rectangle daire = new Rectangle(BaslangicX, SonY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                }
                else
                {
                    Cap = 698 - BaslangicX;
                    SonX = BaslangicX + (int)Cap;
                    SonY = BaslangicY - (int)Cap;
                    Rectangle daire = new Rectangle(BaslangicX, SonY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                }
            }
            else if (BaslangicX >= x && BaslangicY <= y)
            {
                if (BaslangicX - (int)Cap >= 0)
                {
                    SonX = BaslangicX - (int)Cap;
                    SonY = BaslangicY + (int)Cap;
                    Rectangle daire = new Rectangle(SonX, BaslangicY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                }
                else
                {
                    Cap = BaslangicX;
                    SonX = BaslangicX - (int)Cap;
                    SonY = BaslangicY + (int)Cap;
                    Rectangle daire = new Rectangle(SonX, BaslangicY, (int)Cap, (int)Cap);
                    cizimAraci.FillEllipse(_brush, daire);
                }

            }
        }

        public override bool Sec(Graphics cizimAraci, Pen _brush, int x, int y)
        {
            if (x <= SonX && x >= BaslangicX && y >= BaslangicY && y <= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY - 4), new Point(SonX, BaslangicY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX + 4, BaslangicY), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY + 4), new Point(BaslangicX, SonY + 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - 4, SonY), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x >= SonX && x <= BaslangicX && y <= BaslangicY && y >= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY + 4), new Point(SonX, BaslangicY + 4));
                cizimAraci.DrawLine(_brush, new Point(SonX - 4, BaslangicY), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY - 4), new Point(BaslangicX, SonY - 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + 4, SonY), new Point(BaslangicX + 4, BaslangicY));
                return true;
            }
            else if (x <= SonX && x >= BaslangicX && y <= BaslangicY && y >= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY + 4), new Point(SonX, BaslangicY + 4));
                cizimAraci.DrawLine(_brush, new Point(SonX + 4, BaslangicY), new Point(SonX + 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY - 4), new Point(BaslangicX, SonY - 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX - 4, SonY), new Point(BaslangicX - 4, BaslangicY));
                return true;
            }
            else if (x >= SonX && x <= BaslangicX && y >= BaslangicY && y <= SonY)
            {
                cizimAraci.DrawLine(_brush, new Point(BaslangicX, BaslangicY - 4), new Point(SonX, BaslangicY - 4));
                cizimAraci.DrawLine(_brush, new Point(SonX - 4, BaslangicY), new Point(SonX - 4, SonY));
                cizimAraci.DrawLine(_brush, new Point(SonX, SonY + 4), new Point(BaslangicX, SonY + 4));
                cizimAraci.DrawLine(_brush, new Point(BaslangicX + 4, SonY), new Point(BaslangicX + 4, BaslangicY));
                return true;
            }
            return false;
        }
    }
}
