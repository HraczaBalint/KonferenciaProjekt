using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KonferenciaProjekt
{
    public partial class FormEloadasok : Form
    {
        Konferencia konferencia = new Konferencia("konferencia.txt");

        int aktualis = 0;

        public FormEloadasok()
        {
            InitializeComponent();
        }

        private void FormEloadasok_Load(object sender, EventArgs e)
        {
            Form_betoltese();
            Ertekeles_Betoltese();
        }

        private void Form_betoltese()
        {
            buttonBal.BackgroundImage = Image.FromFile(@"Kepek/bal.jpg");
            buttonBal.BackgroundImageLayout = ImageLayout.Zoom;

            buttonJobb.BackgroundImage = Image.FromFile(@"Kepek/jobb.jpg");
            buttonJobb.BackgroundImageLayout = ImageLayout.Zoom;

            buttonMent.BackgroundImage = Image.FromFile(@"Kepek/ment.jpg");
            buttonMent.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Ertekeles_Betoltese()
        {
            panelErtekeles.Controls.Clear();

            Eloadas aktualisEloadas = konferencia.Eloadasok[aktualis];

            this.Text = konferencia.Eloadasok[aktualis].Cim.ToString() + " ( " + aktualisEloadas.atlagSzamolas() + " )";
            pictureBoxIro.Image = Image.FromFile(@"Kepek/" + aktualisEloadas.Cim.Split(' ')[0].ToString() + ".jpg");
            pictureBoxIro.SizeMode = PictureBoxSizeMode.Zoom;


            int meret = 40;
            for (int i = 0; i < aktualisEloadas.SorDb; i++)
            {
                for (int j = 0; j < aktualisEloadas.HelyDb; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SetBounds(j * meret, i * meret, meret, meret);
                    pictureBox.Image = Image.FromFile(@"Kepek/Pont" + aktualisEloadas.Ertekeles[i, j] + ".jpg");
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    int iErteke = i;
                    int jErteke = j;

                    pictureBox.Click += (o, e) =>
                    {
                        switch (aktualisEloadas.Ertekeles[iErteke, jErteke])
                        {
                            case 1:
                                aktualisEloadas.Ertekeles[iErteke, jErteke] = 2;
                                break;
                            case 2:
                                aktualisEloadas.Ertekeles[iErteke, jErteke] = 3;
                                break;
                            case 3:
                                aktualisEloadas.Ertekeles[iErteke, jErteke] = 1;
                                break;
                            default:
                                MessageBox.Show("Az adott helyen nem ült senki!");;
                                break;
                        }

                        Ertekeles_Betoltese();
                    };

                    panelErtekeles.Controls.Add(pictureBox);
                }
            }
        }

        private void buttonBal_Click(object sender, EventArgs e)
        {
            aktualis--;

            if (aktualis < 0)
            {
                aktualis = konferencia.Eloadasok.Count - 1;
            }

            Ertekeles_Betoltese();
        }

        private void buttonJobb_Click(object sender, EventArgs e)
        {
            aktualis++;

            if (aktualis > konferencia.Eloadasok.Count - 1)
            {
                aktualis = 0;
            }

            Ertekeles_Betoltese();
        }

        private void buttonMent_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("konferencia.txt", "konferencia.bak", true);

                using (StreamWriter sw = new StreamWriter("konferencia.txt", false))
                {
                    foreach (var eloadas in konferencia.Eloadasok)
                    {
                        sw.WriteLine(eloadas.Cim);
                        sw.WriteLine($"{eloadas.SorDb};{eloadas.HelyDb}");
                        for (int i = 0; i < eloadas.SorDb; i++)
                        {
                            string s = "";

                            for (int j = 0; j < eloadas.HelyDb; j++)
                            {
                                s += eloadas.Ertekeles[i, j].ToString() + ";";
                            }

                            sw.WriteLine(s.Substring(0, s.Length - 1));
                        }
                        sw.WriteLine();
                    }
                    MessageBox.Show("Sikeres mentés!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
