using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Telekocsi_Form
{
    public partial class FrmFo : Form
    {
        private List<Auto> autok = new List<Auto>();
        private List<Igeny> igenyek = new List<Igeny>();

        public FrmFo()
        {
            InitializeComponent();
            lbKimenet.Items.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader file = new StreamReader("autok.csv");
                file.ReadLine();

                while (!file.EndOfStream)
                {
                    string[] adat = file.ReadLine().Split(';');
                    autok.Add(new Auto(adat[0], adat[1], adat[2], adat[3], Convert.ToInt32(adat[4])));

                }
                file.Close();

                StreamReader file2 = new StreamReader("igenyek.csv");
                file2.ReadLine();

                while (!file2.EndOfStream)
                {
                    string[] i = file2.ReadLine().Split(';');
                    igenyek.Add(new Igeny(i[0], i[1], i[2], Convert.ToInt32(i[3])));
                }
                file2.Close();

                btnSecond.Enabled = true;
                btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Add("2. feladat");
            lbKimenet.Items.Add($"    {autok.Count} autós hirdet fuvart");

            btnSecond.Enabled = false;
            btnThird.Enabled = true;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("3. feladat");
            int ferohelyek = 0;
            foreach (var a in autok)
            {
                if (a.Utvonal == "Budapest-Miskolc")
                {
                    ferohelyek = ferohelyek + a.Ferohely;
                }
            }
            lbKimenet.Items.Add($" Összesen { ferohelyek} férőhelyet hirdettek az autósok Budapestről Miskolcra.");
            btnThird.Enabled = false;
            btnFourth.Enabled = true;
        }

        private void btnFourth_Click(object sender, EventArgs e)
        {
            
            int max = 0;
            string utv = "";

            var utvonalak = from a in autok
                            orderby a.Utvonal
                            group a by a.Utvonal into temp
                            select temp;

            foreach (var ut in utvonalak)
            {
                int fh = ut.Sum(x => x.Ferohely);
                if (max < fh)
                {
                    max = fh;
                    utv = ut.Key;
                }
            }

            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("4. feladat");
            lbKimenet.Items.Add("A legtöbb férőhelyet");
            lbKimenet.Items.Add($"({max})");
            lbKimenet.Items.Add("a");
            lbKimenet.Items.Add($"{utv} útvonalon");
            lbKimenet.Items.Add("ajánlották fel a hírdetők");

            btnFourth.Enabled = false;
            btnFifht.Enabled = true;
        }
       
        private void btnFifht_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("5. feladat");

            foreach (var ig in igenyek)
            {
                int i = ig.VanAuto(autok);
                if (i > -1)
                {
                    lbKimenet.Items.Add($"{ig.Azonosito} => {autok[i].Rendszam}");

                }
            }
            btnFifht.Enabled = false;
            btnsixth.Enabled = true;
        }

        private void btnsixth_Click(object sender, EventArgs e)
        {
            try
            {
                lbKimenet.Items.Clear();
                lbKimenet.Items.Add("6. feladat");
                StreamWriter fajl = new StreamWriter("utasuzenetek.txt");
                foreach (var ig in igenyek)
                {
                    int i = ig.VanAuto(autok);

                    if (i > -1)
                    {
                        fajl.WriteLine($"{ig.Azonosito}: Rendszám: {autok[i].Rendszam}, Telefonszám: {autok[i].Telefonszam}");
                    }
                    else
                    {
                        fajl.WriteLine($"{ig.Azonosito}: Sajnos nem sikerült autót találni");
                    }

                    fajl.Close();
                    lbKimenet.Items.Add("Adat fájlba írása megtörtént");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
