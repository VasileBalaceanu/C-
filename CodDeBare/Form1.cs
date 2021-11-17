using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ZXing;

namespace CodDeBare
{
    public partial class Form1 : Form
    {
        Image img;
        Graphics g;
        int sumapare = 0, sumaimpare = 0, i, j, lungimetextprimit, sumaparesiimpare,cheie;
        long nrprimit;
        int[,] cod;
        int latimegros = 4, latimesubtire = 2, inaltime = 40, latimebare1cifra, latimebarecifre; //pentru desenarea barelor
        int xstartbare, ystartbare, xtextdescris, ytextdescris,xbareretinut,ybareretinut,xfinalbare;

       

        bool periefolositaneagra = true, nrparcifreok=false;
        SolidBrush perieneagra = new SolidBrush(Color.Black);
        SolidBrush periealba = new SolidBrush(Color.White);
        Font fontt = new Font("Times New Roman", 13);
       
        public Form1()
        {
            InitializeComponent();
        }
        private void valintrodusa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(valintrodusa.Text))
            {
                ButonGenereaza.Enabled = false;
                aparechenar.Enabled = false;
            }
            else
            {
                aparechenar.Enabled = true;
                ButonGenereaza.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calculeaza();
            imaginenoua();
            genereaza(g);
        }
        private void valintrodusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {//testeaza daca tasta apasata este CTRL ori vreun caracter non-numeric
                e.Handled = true;
            }
        }
        private void ButonGenereaza_Click(object sender, EventArgs e)
        {
            calculeaza(); 
            imaginenoua();
            genereaza(g);
        }
        private void ButonSalveaza_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG) | *.jpg";


            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ButonSalveaza.Enabled = false;
            ButonGenereaza.Enabled = false;
            aparechenar.Enabled = false;
            img = new Bitmap(pb.Width, pb.Height);   
            g = Graphics.FromImage(img);
            //g.Clear(Color.LightBlue);
        }
        private void pb_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }
        void calculeaza()
        {
            lungimetextprimit = valintrodusa.Text.Length;
            if (lungimetextprimit % 2 == 0)
            {
                nrparcifreok = true;
                coddeafisat.Clear();
                ButonSalveaza.Enabled = true;
                
                latimebare1cifra = latimegros * 2 + latimesubtire * 3; // pentru o cifra
                latimebarecifre = latimebare1cifra * (lungimetextprimit + 2); // pentru toate cifrele ce vor urma reprezentate

                xstartbare = (pb.Width - latimebarecifre) / 2;
                ystartbare = (pb.Height - inaltime) / 2;

                xbareretinut = xstartbare;
                ybareretinut = ystartbare;


                nrprimit = Int64.Parse(valintrodusa.Text);
                cod = new int[6, lungimetextprimit + 2]; // de ex lungime = 4 luam cod[6] adica pozitii de la 0 la 5. Pozitia 0 va fi cu 0, cod[6]=cheia, restul sunt nr primite
                for (i = lungimetextprimit; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        cod[0, i] = Convert.ToInt32(nrprimit % 10);
                        nrprimit = nrprimit / 10;
                    }
                    else
                        cod[0, i] = 0;//cod[0,0] ia valoarea 0;
                }

                for (i = 1; i <= lungimetextprimit; i = i + 2)
                {
                    sumaimpare = sumaimpare + cod[0, i];//suma cifrelor de pe pozitiile impare
                }

                for (i = 2; i <= lungimetextprimit; i = i + 2)
                {
                    sumapare = sumapare + cod[0, i];//suma cifrelor de pe pozitiile pare
                }
                sumaparesiimpare = sumaimpare + sumapare * 3; // suma impare + (pare*3)

                for (i = 0; i <= 9; i++)
                {
                    if ((sumaparesiimpare + i) % 10 == 0)
                    {
                        cheie = i; // cautare cheie
                        break;
                    }
                }

                cod[0, lungimetextprimit + 1] = cheie;

                for (i = 0; i < lungimetextprimit + 2; i++)
                {
                    if (cod[0, i] == 0)
                    {
                        cod[1, i] = 0; cod[2, i] = 0; cod[3, i] = 1; cod[4, i] = 1; cod[5, i] = 0;
                    }
                    if (cod[0, i] == 1)
                    {
                        cod[1, i] = 1; cod[2, i] = 0; cod[3, i] = 0; cod[4, i] = 0; cod[5, i] = 1;
                    }
                    if (cod[0, i] == 2)
                    {
                        cod[1, i] = 0; cod[2, i] = 1; cod[3, i] = 0; cod[4, i] = 0; cod[5, i] = 1;
                    }
                    if (cod[0, i] == 3)
                    {
                        cod[1, i] = 1; cod[2, i] = 1; cod[3, i] = 0; cod[4, i] = 0; cod[5, i] = 0;
                    }
                    if (cod[0, i] == 4)
                    {
                        cod[1, i] = 0; cod[2, i] = 0; cod[3, i] = 1; cod[4, i] = 0; cod[5, i] = 1;
                    }
                    if (cod[0, i] == 5)
                    {
                        cod[1, i] = 1; cod[2, i] = 0; cod[3, i] = 1; cod[4, i] = 0; cod[5, i] = 0;
                    }
                    if (cod[0, i] == 6)
                    {
                        cod[1, i] = 0; cod[2, i] = 1; cod[3, i] = 1; cod[4, i] = 0; cod[5, i] = 0;
                    }
                    if (cod[0, i] == 7)
                    {
                        cod[1, i] = 0; cod[2, i] = 0; cod[3, i] = 0; cod[4, i] = 1; cod[5, i] = 1;
                    }
                    if (cod[0, i] == 8)
                    {
                        cod[1, i] = 1; cod[2, i] = 0; cod[3, i] = 0; cod[4, i] = 1; cod[5, i] = 0;
                    }
                    if (cod[0, i] == 9)
                    {
                        cod[1, i] = 0; cod[2, i] = 1; cod[3, i] = 0; cod[4, i] = 1; cod[5, i] = 0;
                    }
                } //fiecarei cifre primite i am asociat codul binar pt bare   

                for (i = 0; i < lungimetextprimit + 2; i++)
                {
                    coddeafisat.Text = coddeafisat.Text + cod[0, i].ToString();
                } // scriere in coddeafisat din dreapta 
            }
            else
            {
                MessageBox.Show("Te rugam sa introduci un numar par de cifre");
            }
        }
        void genereaza(Graphics g)
        {
           // xfinalbare = 0;
            if (nrparcifreok)
            {
                xfinalbare = 0;
                nrparcifreok = false;
                periefolositaneagra = true;
                for (i = 0; i < lungimetextprimit + 2; i++)
                {
                    for (j = 1; j < 6; j++)
                    {
                            if (cod[j, i] == 1)
                            {
                                xfinalbare = xfinalbare + latimegros;
                            }
                            if (cod[j, i] == 0)
                            {
                                xfinalbare = xfinalbare + latimesubtire;
                            }
                            periefolositaneagra = false;
                    }
                }//obtinere lungime cod de bare
                if (aparechenar.Checked == true)
                {
                    g.FillRectangle(periealba, xbareretinut - 10, ybareretinut - 10, xfinalbare+20, ystartbare + inaltime) ;
                    //g.FillRectangle(periealba,0, 0, pb.Width,pb.Height);

                } // desenare fundal alb data este dorit

                for (i = 0; i < lungimetextprimit + 2; i++)
                {
                    for (j = 1; j < 6; j++)
                    {
                        if (periefolositaneagra)
                        {
                            if (cod[j, i] == 1)
                            {
                                g.FillRectangle(perieneagra, xstartbare, ystartbare, latimegros, inaltime);
                                xstartbare = xstartbare + latimegros;
                            }
                            if (cod[j, i] == 0)
                            {
                                g.FillRectangle(perieneagra, xstartbare, ystartbare, latimesubtire, inaltime);
                                xstartbare = xstartbare + latimesubtire;
                            }
                            periefolositaneagra = false;
                        }
                        else
                        {
                            if (cod[j, i] == 1)
                            {
                                g.FillRectangle(periealba, xstartbare, ystartbare, latimegros, inaltime);
                                xstartbare = xstartbare + latimegros;
                            }
                            if (cod[j, i] == 0)
                            {
                                g.FillRectangle(periealba, xstartbare, ystartbare, latimesubtire, inaltime);
                                xstartbare = xstartbare + latimesubtire;
                            }
                            periefolositaneagra = true;
                        }

                    }
                } // desenare cod de bare


                xtextdescris = (pb.Width - (Convert.ToInt32(fontt.Size) * (lungimetextprimit + 2))+(lungimetextprimit+1)*4) / 2;
                ytextdescris = ystartbare + inaltime - 3;


                for (i = 0; i < lungimetextprimit + 2; i++)
                {
                    g.DrawString(cod[0,i].ToString(), fontt, perieneagra, xtextdescris, ytextdescris);
                    xtextdescris = xtextdescris + Convert.ToInt32(fontt.Size)-4;
                }//scris cod sub cod de bare
               
                pb.Refresh();
            }
        }
        void imaginenoua()
        {
           
            sumapare = 0;
            sumaimpare = 0;
            img = new Bitmap(pb.Width, pb.Height);
            g = Graphics.FromImage(img);
            g.Clear(Color.LightBlue);
        }
        private void butonopenfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = new Bitmap(pb.Width, pb.Height);
                    g = Graphics.FromImage(img);
                    pb.Image = Image.FromFile(ofd.FileName);
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode((Bitmap)pb.Image);
                    if (result != null)
                        txtBarcode.Text = result.ToString();
                }
            }
        }
    }
}
