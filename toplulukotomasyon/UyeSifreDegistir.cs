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

    public partial class UyeSifreDegistir : Form
    {

        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public UyeSifreDegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _kayitlisifre;
            string _mevcut;
            string _yeni;
            string _yenii;

            _mevcut = Convert.ToString(mevcutsifre.Text);
            _yeni = Convert.ToString(yenisifre.Text);
            _yenii = Convert.ToString(yenisifree.Text);

            con.Open();
            MySqlCommand smd = new MySqlCommand("SELECT uye_sifre FROM uyeler WHERE uye_ogrencino=@ogrno", con);
            smd.Parameters.AddWithValue("@ogrno", UyeGiris.gkadi);
            MySqlDataReader sr = smd.ExecuteReader();
            if (sr.Read())
            {
                _kayitlisifre = sr["uye_sifre"].ToString();
                con.Close();
                if (_kayitlisifre == _mevcut)
                {
                    if(_yeni == _yenii)
                    {
                        con.Open();
                        MySqlCommand kmd = new MySqlCommand("UPDATE uyeler SET uye_sifre='" + _yeni + "' WHERE uye_ogrencino='" + UyeGiris.gkadi + "'", con);
                        kmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Şifre Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                        UyeGirisEkranı f5 = new UyeGirisEkranı();
                        f5.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yeni Şifre Uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Mevcut Şifre Yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            
        }
    }
}
