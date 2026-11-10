using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cukraszda
{
    public partial class arlistaform : Form
    {
        Dictionary<string, int> suti = new Dictionary<string, int>();
        List<CheckBox> checkb = new List<CheckBox>();
        List<NumericUpDown> db = new List<NumericUpDown>();
        List<int> reszossz = new List<int>();
        int osszeg = 0;
        public arlistaform(Dictionary<string, int> sutik)
        {
            InitializeComponent();
            this.suti = sutik;
            int i = 0;
            // Foreach ciklussal végig megyek a dict minden elemén (minden sütin)
            // És mindegyiknek csinálok egy checkboxot és egy mennyiség választót
            foreach (KeyValuePair<string, int> elem in suti)
            {
                // CheckBoxok és süti nevek és árak kiiratása és elhelyezése
                // Mindegyiket 30px-l lejebb mint az előzőt
                CheckBox cb = new CheckBox();
                cb.Text = $"{elem.Key} - {elem.Value} Ft";
                cb.Location = new Point(50, 100 + 30 * i);
                cb.AutoSize = true;
                cb.Tag = elem.Key;
                this.Controls.Add(cb);
                checkb.Add(cb);

                // Minden sütinek deklarálok egy db választót és a checkboxok mellé teszem.
                NumericUpDown num = new NumericUpDown();
                num.Minimum = 1;
                num.Maximum = 100;
                num.Value = 1;
                num.Location = new Point(350, 100 + 30 * i);
                this.Controls.Add(num);
                db.Add(num);
                i++;
            }

            // For ciklussal ellenőrzés, hogy bevan-e pipálva, és ha igen, hány db van belőle
            for (int x = 0; x < checkb.Count; x++)
            {
                if (checkb[x].Checked)
                {
                    string nev = checkb[x].Tag.ToString();
                    int ar = suti[nev];
                    int menny = (int)db[x].Value;
                    int reszosz = ar * menny;
                    reszossz.Add(reszosz);

                }
            }
            foreach (int o in reszossz)
            {
                osszeg += o;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szamlaform szamla = new szamlaform(osszeg, reszossz);
        }

        private void arlistaform_Load(object sender, EventArgs e)
        {

        }
    }
}
