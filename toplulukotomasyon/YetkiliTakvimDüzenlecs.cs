using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toplulukotomasyon
{
    public partial class YetkiliTakvimDüzenlecs : Form
    {
        public YetkiliTakvimDüzenlecs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            YeniEtkinlikOlustur f5 = new YeniEtkinlikOlustur();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EtkinlikDüzenle f5 = new EtkinlikDüzenle();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EtkinlikleriListele f5 = new EtkinlikleriListele();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }
    }
}
