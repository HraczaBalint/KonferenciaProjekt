using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonferenciaProjekt
{
    class Eloadas
    {
        private string cim;
        private int sorDb;
        private int helyDb;
        private int[,] ertekeles;

        public Eloadas(string cim, int sorDB, int helydB, int[,] ertekeles)
        {
            this.cim = cim;
            this.sorDb = sorDB;
            this.helyDb = helydB;
            this.ertekeles = ertekeles;
        }

        public string Cim { get => cim; }
        public int SorDb { get => sorDb; }
        public int HelyDb { get => helyDb; }
        public int[,] Ertekeles { get => ertekeles; }

        public double atlagSzamolas()
        {
            double osszeg = 0;
            int darabszam = 0;

            for (int i = 0; i < sorDb; i++)
            {
                for (int j = 0; j < helyDb; j++)
                {
                    if (ertekeles[i,j] > 0)
                    {
                        osszeg += ertekeles[i,j];
                        darabszam++;
                    }
                }
            }

            return Math.Round(osszeg / darabszam, 1);
        }
    }
}
