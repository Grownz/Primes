using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primes
{
        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IstPrim(long a)
        {
            if (a == 2) return true;
            for (long i = 2; i < (long)Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        public void ParallelSuche(int start, int end)
        {
            
            this.ButtonGo.Text = "Berechnet";
            this.ButtonGo.Enabled = false;
            this.PrimListe.Items.Clear();
            IEnumerable<int> numbers = Enumerable.Range(start, (end - start));

            var parallelQuery =
                from n in numbers.AsParallel()
                where Enumerable.Range(2, (int)Math.Sqrt(n)).All(i => n % i > 0)
                select n;
            int[] primes = parallelQuery.ToArray();

            for (int i = 0; i < primes.Length; i++)
            {
                string ListItem = i + ":\t" + primes[i];
                PrimListe.Items.Add(ListItem);
            }
            PrimListe.SelectedItem = (PrimListe.Items.Count);
            this.ButtonGo.Text = "GO!";
            this.ButtonGo.Enabled = true;
        }

        public void SeriellSuche(long start, long end)
        {
            this.ButtonGo.Text = "Berechnet";
            this.ButtonGo.Enabled = false;
            this.PrimListe.Items.Clear();
            if (start % 2 == 0) ++start;
            for (long i = start; i < end; i+=2)
            {
                if (this.IstPrim(i))
                {
                    this.PrimListe.Items.Add(i.ToString());
                }
            }
            this.ButtonGo.Text = "GO!";
            this.ButtonGo.Enabled = true;
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            if (this.StartBox.Text == "" || this.EndBox.Text == "")
            {
                MessageBox.Show("Bitte in beide Eingabefelder eine Zahl eingeben!");

            }

            else
            {
                if (this.ButtonM1.Checked)
                {
                    if (Convert.ToInt64(this.StartBox.Text) > int.MaxValue || Convert.ToInt64(this.EndBox.Text) > int.MaxValue)
                    {
                        MessageBox.Show("Parralelberechnung nur zwischen 0 und " + int.MaxValue + " möglich.");
                    }
                    else this.ParallelSuche(Convert.ToInt32(this.StartBox.Text), Convert.ToInt32(this.EndBox.Text));
                }

                else if (this.ButtonM2.Checked)
                {
                    this.SeriellSuche(Convert.ToInt64(this.StartBox.Text), Convert.ToInt64(this.EndBox.Text));
                }

                else
                {
                    MessageBox.Show("Bitte eine Berechnungsmethode auswählen!");
                }
            }


           
        }


    }
}
