using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KonferenciaProjekt
{
    class Konferencia
    {
        private List<Eloadas> eloadasok = new List<Eloadas>();

        internal List<Eloadas> Eloadasok { get => eloadasok; }

        public Konferencia(string filenev)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while (!sr.EndOfStream)
                    {
                        string cim = sr.ReadLine();
                        string[] helyAdat = sr.ReadLine().Split(';');
                        int sorDb = int.Parse(helyAdat[0]);
                        int helyDb = int.Parse(helyAdat[1]);
                        int[,] ertekeles = new int[sorDb, helyDb];

                        for (int i = 0; i < sorDb; i++)
                        {
                            helyAdat = sr.ReadLine().Split(';');

                            for (int j = 0; j < helyDb; j++)
                            {
                                ertekeles[i, j] = int.Parse(helyAdat[j]);
                            }
                        }

                        sr.ReadLine();

                        Eloadas eloadas = new Eloadas(cim, sorDb, helyDb, ertekeles);
                        eloadasok.Add(eloadas);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Environment.Exit(0);
            }   
        }
    }
}
