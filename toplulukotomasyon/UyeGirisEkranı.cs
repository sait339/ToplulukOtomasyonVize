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
    public partial class UyeGirisEkranı : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public UyeGirisEkranı()
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Bilgilerim f2 = new Bilgilerim();
            f2.Dock = DockStyle.Fill;
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UyeSifreDegistir f3 = new UyeSifreDegistir();
            f3.Dock = DockStyle.Fill;
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TopluluklariGoruntule f5 = new TopluluklariGoruntule();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UyeOldugumTopluluklar f5 = new UyeOldugumTopluluklar();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }

        
        private void UyeGirisEkranı_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT uye_adi,uye_soyadi,uye_ogrencino,siniflar_bolumler_bolum_id,siniflar_sinif_id FROM uyeler WHERE uye_ogrencino=@ogrno", con);
            hmd.Parameters.AddWithValue("@ogrno", UyeGiris.gkadi);
            MySqlDataReader hr = hmd.ExecuteReader();
            if (hr.Read())
            {
                _gadi = hr["uye_adi"].ToString();
                _gsoyadi = hr["uye_soyadi"].ToString();
                _gogrno = hr["uye_ogrencino"].ToString();
                _blmid = hr["siniflar_bolumler_bolum_id"].ToString();
                _snfid = hr["siniflar_sinif_id"].ToString();
                label1.Text = _gadi + " "+ _gsoyadi;
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

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            EtkinlikTakvimi f5 = new EtkinlikTakvimi();
            f5.Dock = DockStyle.Fill;
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }
    }
}
