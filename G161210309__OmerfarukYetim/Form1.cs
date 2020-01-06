using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G161210309__OmerfarukYetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        bool ciz = false;
        bool sec = false;
        int tempX, tempY;
        int secilenX = 956, secilenY = 979;
        string ad = "", renk = "";
        System.Drawing.Color clr;
        Cokgen cObje;
        List<Cokgen> cokgenler = new List<Cokgen>();



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciz && e.X <= 956 && e.Y <= 979 && e.X >= 0 && e.Y >= 0)
            {
                if (ad == "dorgen")
                {
                    Graphics cizimAraci = panel1.CreateGraphics();
                    SolidBrush _brush = new SolidBrush(clr);
                    cObje = new Dortgen();
                    cizimAraci.Clear(Color.White);
                    yenidenCiz();
                    cObje.Ad = ad;
                    cObje.BaslangicX = tempX;
                    cObje.BaslangicY = tempY;
                    cObje.Renk = clr;
                    cObje.ciz(cizimAraci, _brush, e.X, e.Y);
                }
                else if (ad == "daire")
                {
                    Graphics cizimAraci = panel1.CreateGraphics();
                    SolidBrush _brush = new SolidBrush(clr);
                    cObje = new Daire();
                    cizimAraci.Clear(Color.White);
                    yenidenCiz();
                    cObje.Ad = ad;
                    cObje.BaslangicX = tempX;
                    cObje.BaslangicY = tempY;
                    cObje.Renk = clr;
                    cObje.ciz(cizimAraci, _brush, e.X, e.Y);
                }
                else if (ad == "ucgen")
                {
                    Graphics cizimAraci = panel1.CreateGraphics();
                    SolidBrush _brush = new SolidBrush(clr);
                    cObje = new Ucgen();
                    cizimAraci.Clear(Color.White);
                    yenidenCiz();
                    cObje.Ad = ad;
                    cObje.BaslangicX = tempX;
                    cObje.BaslangicY = tempY;
                    cObje.Renk = clr;
                    cObje.ciz(cizimAraci, _brush, e.X, e.Y);
                }
                else if (ad == "altigen")
                {
                    Graphics cizimAraci = panel1.CreateGraphics();
                    SolidBrush _brush = new SolidBrush(clr);
                    cObje = new Altigen();
                    cizimAraci.Clear(Color.White);
                    yenidenCiz();
                    cObje.Ad = ad;
                    cObje.BaslangicX = tempX;
                    cObje.BaslangicY = tempY;
                    cObje.Renk = clr;
                    cObje.ciz(cizimAraci, _brush, e.X, e.Y);
                }

            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
            if (ad != "" && renk != "")
                cokgenler.Add(cObje);
        }

        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ad != "" && renk != "")
                ciz = true;
            tempX = e.X;
            tempY = e.Y;
            if (sec == true) 
            {
                secilenX = e.X;
                secilenY = e.Y;
                Graphics cizimAraci = panel1.CreateGraphics();
                Pen _brush = new Pen(Color.Brown, 8);
                cizimAraci.Clear(Color.White);
                yenidenCiz();
                for (int i = 0; i < cokgenler.Count; i++)
                {
                    cokgenler[i].Sec(cizimAraci, _brush, e.X, e.Y);
                }
            }
        }

        private void secPictureBox_Click(object sender, EventArgs e)
        {
            sec = true;
            secPictureBox.BackColor = Color.Green;
            ad = "";
            renk = "";
        }

        private void silPictureBox_Click(object sender, EventArgs e)
        {
            ad = "";
            renk = "";
            if (sec == true)
            {
                Graphics cizimAraci = panel1.CreateGraphics();
                Pen _brush = new Pen(Color.Brown, 8);
                for (int i = 0; i < cokgenler.Count; i++)
                {
                    if (cokgenler[i].Sec(cizimAraci, _brush, secilenX, secilenY))
                    {
                        cokgenler.RemoveAt(i);
                        i--;
                    }
                }
                secilenX = 956;
                secilenY = 979;
            }
            
        }

        private void kaydetPictureBox_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Metin Belgesi |*.txt";
            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string dosya_yolu = @file.FileName;
                    FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    for (int i = 0; i < cokgenler.Count; i++)
                    {
                        sw.WriteLine(cokgenler[i].Ad + " " + cokgenler[i].BaslangicX + " " + cokgenler[i].BaslangicY + " " + cokgenler[i].SonX + " " + cokgenler[i].SonY + " " + cokgenler[i].Renk.Name);
                    }
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dosya Kaydedilemedi");

            }
        }

        private void kareBtn_Click(object sender, EventArgs e)
        {
            ad = "dorgen";
            kareBtn.BackColor = Color.Silver;
        }

        private void daireBtn_Click(object sender, EventArgs e)
        {

            ad = "daire";
            daireBtn.BackColor = Color.Silver;
        }

        private void ucgenBtn_Click(object sender, EventArgs e)
        {
            ad = "ucgen";
            ucgenBtn.BackColor = Color.Silver;
        }

        private void altigenBtn_Click(object sender, EventArgs e)
        {
            ad = "altigen";
            altigenBtn.BackColor = Color.Silver;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            renk = "red";
            clr = Color.Red;
            
            
            redBtn.BackColor = Color.Red;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            renk = "blue";
            clr = Color.Blue;
            blueBtn.BackColor = Color.Blue;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            renk = "green";
            clr = Color.Green;
            greenBtn.BackColor = Color.Green;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void bisqueBtn_Click(object sender, EventArgs e)
        {
            renk = "bisque";
            clr = Color.Bisque;
            bisqueBtn.BackColor = Color.Bisque;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void blackBtn_Click(object sender, EventArgs e)
        {
            renk = "black";
            clr = Color.Black;
            blackBtn.BackColor = Color.Black;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            renk = "yellow";
            clr = Color.Yellow;
            yellowBtn.BackColor = Color.Yellow;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void purpleBtn_Click(object sender, EventArgs e)
        {
            renk = "purple";
            clr = Color.Purple;
            purpleBtn.BackColor = Color.Purple;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void brownBtn_Click(object sender, EventArgs e)
        {
            renk = "brown";
            clr = Color.Brown;
            brownBtn.BackColor = Color.Brown;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void whiteBtn_Click(object sender, EventArgs e)
        {

            renk = "white";
            clr = Color.White;
            whiteBtn.BackColor = Color.White;
            if (sec == true)
            {
                renkDegistir(clr);
                sec = false;
                secPictureBox.BackColor = this.BackColor;
            }
        }

        private void dosyaAcPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Metin Belgesi |*.txt";
            file.Multiselect = false;
            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string dosya_yolu = @file.FileName;
                    FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                    StreamReader sw = new StreamReader(fs);
                    string satir, sekil, rnk;
                    string[] degerler;
                    int bX, bY, sX, sY;
                    Graphics cizimAraci = panel1.CreateGraphics();
                    cizimAraci.Clear(Color.White);
                    cokgenler.Clear();
                    SolidBrush firca = new SolidBrush(Color.White);
                    while (!sw.EndOfStream)
                    {
                        satir = sw.ReadLine();
                        degerler = satir.Split(' ');
                        sekil = degerler[0];
                        bX = int.Parse(degerler[1]);
                        bY = int.Parse(degerler[2]);
                        sX = int.Parse(degerler[3]);
                        sY = int.Parse(degerler[4]);
                        rnk = degerler[5];

                        if (rnk == "Red")
                            firca.Color = Color.Red;
                        else if (rnk == "Blue")
                            firca.Color = Color.Blue;
                        else if (rnk == "Green")
                            firca.Color = Color.Green;
                        else if (rnk == "Yellow")
                            firca.Color = Color.Yellow;
                        else if (rnk == "Orange")
                            firca.Color = Color.Orange;
                        else if (rnk == "Purple")
                            firca.Color = Color.Purple;
                        else if (rnk == "Black")
                            firca.Color = Color.Black;
                        else if (rnk == "Bisque")
                            firca.Color = Color.Bisque;
                        else if (rnk == "White")
                            firca.Color = Color.White;

                        if (sekil == "dortgen")
                        {
                            cObje = new Dortgen();
                            cObje.Ad = sekil;
                            cObje.BaslangicX = bX;
                            cObje.BaslangicY = bY;
                            cObje.Renk = firca.Color;
                            cObje.ciz(cizimAraci, firca, sX, sY);
                        }
                        else if (sekil == "daire")
                        {
                            cObje = new Daire();
                            cObje.Ad = sekil;
                            cObje.BaslangicX = bX;
                            cObje.BaslangicY = bY;
                            cObje.Renk = firca.Color;
                            cObje.ciz(cizimAraci, firca, sX, sY);
                        }
                        else if (sekil == "ucgen")
                        {
                            cObje = new Ucgen();
                            cObje.Ad = sekil;
                            cObje.BaslangicX = bX;
                            cObje.BaslangicY = bY;
                            cObje.Renk = firca.Color;
                            cObje.ciz(cizimAraci, firca, sX, sY);
                        }
                        else if (sekil == "altigen")
                        {
                            cObje = new Altigen();
                            cObje.Ad = sekil;
                            cObje.BaslangicX = bX;
                            cObje.BaslangicY = bY;
                            cObje.Renk = firca.Color;
                            cObje.ciz(cizimAraci, firca, sX, sY);
                        }
                        cokgenler.Add(cObje);
                    }
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("Dosya Okunamadı");
            }

        }

        

        private void yenidenCiz()
        {
            Graphics cizimAraci = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            for (int i = 0; i < cokgenler.Count; i++)
            {
                brush.Color = cokgenler[i].Renk;
                cokgenler[i].ciz(cizimAraci, brush, cokgenler[i].SonX, cokgenler[i].SonY);
            }
        }

        private void renkDegistir(Color yeniRenk)
        {
            Graphics cizimAraci = panel1.CreateGraphics();
            Pen _brush = new Pen(Color.Brown, 8);
            for (int i = 0; i < cokgenler.Count; i++)
            {
                if (cokgenler[i].Sec(cizimAraci, _brush, secilenX, secilenY))
                    cokgenler[i].Renk = yeniRenk;
            }
            cizimAraci.Clear(Color.White);
            yenidenCiz();
        }

    }
}
