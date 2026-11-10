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
    public partial class szamlaform : Form
    {
        int vegosszeg = 0;
        public szamlaform(int osszeg, List<int> reszossz)
        {
            InitializeComponent();
            vegosszeg += osszeg;
        }

        private void szamlaform_Load(object sender, EventArgs e)
        {

        }
    }
}
