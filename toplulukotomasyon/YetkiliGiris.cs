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
    public partial class YetkiliGiris : Form
    {
        Form f1;
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public YetkiliGiris(Form f)
        {
            f1 = f;
            InitializeComponent();
        }

        private void gerialmabutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string _klncadi;
        string _sifre;
        string _yetki;
        string _tcno;
        public static string gkadi;
        string gsifre;
        private void button1_Click(object sender, EventArgs e)
        {
            gkadi = Convert.ToString(klncadi.Text);
            gsifre = Convert.ToString(sifre.Text);
            con.Close();
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT uye_ogrencino FROM uyeler WHERE uye_ogrencino=@kadi", con);
            hmd.Parameters.AddWithValue("@kadi", gkadi);
            MySqlDataReader cr = hmd.ExecuteReader();
            if (cr.Read())
            {
                _klncadi = cr["uye_ogrencino"].ToString();
                con.Close();
                con.Open();
                MySqlCommand kmd = new MySqlCommand("SELECT uye_sifre,uye_tcno FROM uyeler WHERE uye_ogrencino=@kadi", con);
                kmd.Parameters.AddWithValue("@kadi", gkadi);
                MySqlDataReader kr = kmd.ExecuteReader();
                if (kr.Read())
                {
                    _tcno = kr["uye_tcno"].ToString();
                    _sifre = kr["uye_sifre"].ToString();
                    con.Close();

                    if (_klncadi == gkadi && _sifre == gsifre && _yetki == "1")
                    {
                        MessageBox.Show("Üyeler Yetkili Girişinden giriş yapamaz.Lütfen Üye Girişden giriş yapmayı deneyiniz.", "Dikkat Yetkili Giriş Ekranındasınız.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                    else if (gsifre == _tcno)
                    {
                        this.Close();
                        f1.Hide();
                        YetkiliSifreDegistir f4 = new YetkiliSifreDegistir();
                        f4.Show();
                    }

                    else if (_sifre == gsifre)
                    {
                        con.Open();
                        MySqlCommand ymd = new MySqlCommand("SELECT yetkiler_yetki_id FROM uyeler WHERE uye_ogrencino=@ogrno", con);
                        ymd.Parameters.AddWithValue("@ogrno", _klncadi);
                        MySqlDataReader yr = ymd.ExecuteReader();
                        if (yr.Read())
                        {
                            _yetki = yr["yetkiler_yetki_id"].ToString();
                        }
                        con.Close();
                        if (_klncadi == gkadi && _sifre == gsifre && _yetki != "1")
                        {
                            f1.Hide();
                            YetkiliGirisEkranı f4 = new YetkiliGirisEkranı();
                            f4.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı. Tekrar Deneyiniz", "Hatalı Giriş Yapıldı.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı. Tekrar Deneyiniz", "Hatalı kullanıcı adı.", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            SifremiUnuttum f1 = new SifremiUnuttum();
            f1.ShowDialog();
        }
    }
}
