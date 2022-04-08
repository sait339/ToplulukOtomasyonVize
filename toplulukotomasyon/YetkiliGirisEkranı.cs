using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace toplulukotomasyon
{
    public partial class YetkiliGirisEkranı : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public YetkiliGirisEkranı()
        {
            InitializeComponent();
        }
        string _gadi;
        string _gsoyadi;
        string _gogrno;
        string _blmid;
        string _blmadi;
        string _snfid;
        string _sinifadi;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            anamenu f5 = new anamenu();
            f5.Show();
        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ToplulukBilgileri f5 = new ToplulukBilgileri();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            YetkiliSifreDegistir f5 = new YetkiliSifreDegistir();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ToplulukUyelerListele f5 = new ToplulukUyelerListele();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            YetkiliBilgileri f5 = new YetkiliBilgileri();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            YetkiliTakvimDüzenlecs f5 = new YetkiliTakvimDüzenlecs();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void YetkiliGirisEkranı_Load(object sender, EventArgs e) 
        {
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT uye_adi,uye_soyadi,uye_ogrencino,siniflar_bolumler_bolum_id,siniflar_sinif_id FROM uyeler WHERE uye_ogrencino=@ogrno", con);
            hmd.Parameters.AddWithValue("@ogrno", YetkiliGiris.gkadi);
            MySqlDataReader hr = hmd.ExecuteReader();
            if (hr.Read())
            {
                _gadi = hr["uye_adi"].ToString();
                _gsoyadi = hr["uye_soyadi"].ToString();
                _gogrno = hr["uye_ogrencino"].ToString();
                _blmid = hr["siniflar_bolumler_bolum_id"].ToString();
                _snfid = hr["siniflar_sinif_id"].ToString();
                label1.Text = _gadi + " " + _gsoyadi;
                label2.Text = _gogrno;
            }
            con.Close();
            con.Open();
            MySqlCommand bmd = new MySqlCommand("SELECT bolum_adi FROM bolumler WHERE bolum_id=@blmid", con);
            bmd.Parameters.AddWithValue("@blmid", _blmid);
            MySqlDataReader br = bmd.ExecuteReader();
            if (br.Read())
            {
                _blmadi = br["bolum_adi"].ToString();
                label3.Text = _blmadi;
            }
            con.Close();
            con.Open();
            MySqlCommand smd = new MySqlCommand("SELECT sinif_adi FROM siniflar WHERE sinif_id=@snfid", con);
            smd.Parameters.AddWithValue("@snfid", _snfid);
            MySqlDataReader sr = smd.ExecuteReader();
            if (sr.Read())
            {
                _sinifadi = sr["sinif_adi"].ToString();
                label3.Text += "  /  " + _sinifadi + ". Sınıf";
            }
            con.Close();
        }
    }
}
