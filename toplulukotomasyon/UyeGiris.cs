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
    public partial class UyeGiris : Form
    {
        Form f1;
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        
        public UyeGiris(Form f)
        {
            f1 = f;
            InitializeComponent();
        }
        

        private void gerialmabutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string _klncadi;
        public string _sifre;
        public string _tcno;
        public string _yetki;
        public static string gkadi;
        public string gsifre;
        private void UyeGiris_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            gkadi = Convert.ToString(klncadi.Text);
            gsifre = Convert.ToString(sifre.Text);
            con.Close();
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT uye_ogrencino,yetkiler_yetki_id FROM uyeler WHERE uye_ogrencino=@kadi", con);
            hmd.Parameters.AddWithValue("@kadi", gkadi);
            MySqlDataReader cr = hmd.ExecuteReader();
            if (cr.Read())
            {
                _klncadi = cr["uye_ogrencino"].ToString();
                _yetki = cr["yetkiler_yetki_id"].ToString();
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

                    if (_klncadi == gkadi && _sifre == gsifre && _yetki != "1")
                    {
                        MessageBox.Show("Yetkililer Üye Girişinden giriş yapamaz.Lütfen Yetkili Girişden giriş yapmayı deneyiniz.", "Dikkat Üye Giriş Ekranındasınız.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else if (_klncadi == gkadi && _sifre == _tcno && _yetki == "1")
                    {
                        this.Close();
                        f1.Hide();
                        UyeSifreDegistir f4 = new UyeSifreDegistir();
                        f4.Show();
                    }

                    else if (_sifre != gsifre || gsifre != _tcno)
                    {
                        if (_klncadi == gkadi && _sifre == gsifre && _yetki == "1")
                        {
                            this.Close();
                            f1.Hide();
                            UyeGirisEkranı f4 = new UyeGirisEkranı();
                            f4.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı. Tekrar Deneyiniz", "Hatalı Giriş Yapıldı.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else if(_sifre != gsifre || _klncadi != gkadi)
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
