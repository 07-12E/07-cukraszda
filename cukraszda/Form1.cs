namespace cukraszda
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> sutik = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;

                foreach (string sor in File.ReadLines(file))
                {
                    string[] sorok = sor.Split(';');
                    if (sorok.Length == 2) sutik.Add(sorok[0], int.Parse(sorok[1]));
                }
                süteményekToolStripMenuItem.Enabled = true;
                arlistaform arlista = new arlistaform(sutik);
                arlista.ShowDialog();
            }
        }

        private void süteményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arlistaform arlista = new arlistaform(sutik);
            arlista.ShowDialog();
        }
    }
}
