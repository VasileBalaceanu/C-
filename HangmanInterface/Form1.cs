using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanInterface
{
    public partial class Form1 : Form
    {
        Image img;
        Graphics g;
        cuvant cuv = new cuvant { };
        cuvant tincuvant = new cuvant { };
        char[] numerezerva = new char[] { };
        char[] nameactual = new char[] { };
        char[] literedejaintroduse = new char[] { };
        char[] literaprimita = new char[1];

        Pen pen1 = new Pen(Color.Black, 2);//declaratie penson
        Pen pen2 = new Pen(Color.Red, 2);//declaratie penson

        int nrliterecuvant, nrlitereintroduse , nrvieti , contorgasirilitera;
        int i , n, contor1, contor2;
        bool introdusadeja, dejaliteredejaintroduse;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            jocNou();
        }
        void jocNou()
        {
            nrlitereintroduse = 0;
            nrvieti = 7;
            i = 0; n = 0;contor1 = 0;contor2 = 1;
            butontrimite.Enabled = false;
            img = new  Bitmap(pb.Width, pb.Height);
            g = Graphics.FromImage(img);
            tincuvant = cuv.dacuvant();
            nameactual = (tincuvant.nume).ToCharArray();
            numerezerva = (tincuvant.nume).ToCharArray();
            literedejaintroduse = (tincuvant.nume).ToCharArray();

            rezultat1.Text = tincuvant.nume + " " + tincuvant.incercari;
            nrliterecuvant = nameactual.Length;
            for (i = 0; i < nrliterecuvant; i++)
            {
                nameactual[i] = '_';
                literedejaintroduse[i] = '.';
            }
            foreach (char mychar in nameactual)
            {
                rezultat.Text += mychar.ToString() + ' ';
            }
           
        }
        void deseneazacap(Graphics g)
        {
            g.FillEllipse(Brushes.Orange, 40, 0, 26, 26);//culoare cap
            g.DrawEllipse(pen2, 40, 0, 26, 26);//contur cap
            g.FillEllipse(Brushes.Black, 48, 10, 3, 3);//ochi stang
            g.FillEllipse(Brushes.Black, 58, 10, 3, 3);//ochi drept
            pb.Refresh();
        }
        void deseneazatrunchi(Graphics g)
        {
            g.DrawLine(pen1, 53, 36, 53, 60);//trunchi
            pb.Refresh();
        }
        void deseneazagat(Graphics g)
        {
            g.DrawLine(pen1, 53, 26, 53, 36);//gat
            pb.Refresh();
        }
        void deseneazamanast(Graphics g)
        {
            g.DrawLine(pen1, 53, 36, 41, 53);//mana stanga
            pb.Refresh();
        }
        void deseneazamanadr(Graphics g)
        {
            g.DrawLine(pen1, 53, 36, 65, 53);//mana dreapta
            pb.Refresh();
        }
        void deseneazapiciorst(Graphics g)
        {
            g.DrawLine(pen1, 53, 60, 43, 95);//picior stang
            pb.Refresh();
        }
        void deseneazapiciordr(Graphics g)
        {
            g.DrawLine(pen1, 53, 60, 63, 95);//picior dreapt
            pb.Refresh();
        }

        void scrie()
        {
            introdusadeja = false;
            contorgasirilitera = 0;
            dejaliteredejaintroduse = false;
            try
            {
                literaprimita = literatrimisa.Text.ToCharArray();
                
                if (contor1++ == 0) // se realizeaza doar prima data
                {
                    nrliterecuvant = nameactual.Length;
                    for (i = 0; i < nrliterecuvant; i++)
                    {
                        nameactual[i] = '_';//initializare cuvantu cu _ in locul literelor
                    }
                }
                if (contor2 == 0) // incepe sa se realizeze urmatoarea data dupa ce am pus o litera corecta
                {
                    for (i = 0; i < nrliterecuvant; i++)
                    {
                        if (literaprimita[0] == literedejaintroduse[i])
                        {
                            introdusadeja = true; // testare daca a mai fost introdusa in cuvant deja
                            break;
                        }
                    }
                }
                
                if (introdusadeja == false)
                {
                    for (i = 0; i < nrliterecuvant; i++) 
                    {
                        if (literaprimita[0] == numerezerva[i])
                        {
                            nameactual[i] = literaprimita[0]; // introducere litera in nameactual
                            nrlitereintroduse++; // pentru finalizare cod daca e cazul
                            contorgasirilitera++;// pentru a scadea viata o singura data daca = 0
                            if (dejaliteredejaintroduse == false)
                            {
                                try
                                {
                                    literedejaintroduse[n++] = literaprimita[0];
                                }//introduce litera intr un array pentru a o tine minte pt data viitoare sa nu o mai introduca din nou
                                catch
                                {
                                    MessageBox.Show("aici e problema");// a fost
                                }
                               
                                contor2 = 0;
                                dejaliteredejaintroduse = true;
                            }
                        }
                    }
                }
                if (contorgasirilitera == 0)
                {
                    nrvieti--; 
                }
                switch(nrvieti)
                {
                    case (6):
                        { deseneazacap(g); break; }

                    case (5):
                        { deseneazagat(g);break;}

                    case (4):
                        { deseneazamanadr(g); break;}

                    case (3):
                        {  deseneazamanast(g); break; }

                    case (2):
                        { deseneazatrunchi(g); break; }

                    case (1):
                        { deseneazapiciordr(g); break;}

                    case (0):
                        {deseneazapiciorst(g);break;}
                }
                
                foreach (char mychar in nameactual)
                {
                    rezultat.Text += mychar.ToString() + ' ';
                }

                if (nrvieti == 0)
                {
                    MessageBox.Show("Ai pierdut! Cuvantul a fost: " + tincuvant.nume);
                    this.Close();
                }
                else if (nrlitereintroduse == nrliterecuvant)
                {
                        MessageBox.Show("Ai castigat. Felicitari!");
                        this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Introdu o litera!");
                foreach (char mychar in nameactual)
                {
                    rezultat.Text += mychar.ToString() + ' ';
                }
            }
        }
        private void pb_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezultat.Clear();
            jocNou();
            pb.Image = null;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void literatrimisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(literatrimisa.Text))
            {
                butontrimite.Enabled = false;
            }
            else
            {
                butontrimite.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            rezultat.Clear();
            scrie();
            literatrimisa.Clear();
        }
    }
}
