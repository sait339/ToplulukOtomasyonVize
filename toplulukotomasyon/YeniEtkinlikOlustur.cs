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
    public partial class YeniEtkinlikOlustur : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public YeniEtkinlikOlustur()
        {
            InitializeComponent();
        }

        string _adi;
        string _yer;
        string _tarih;
        string _aciklama;
        string _tid;
        string _uyeid;

        private void button1_Click(object sender, EventArgs e)
            {
            _adi = adi.Text.ToString();
            _yer = yer.Text.ToString();
            _tarih = tarih.Text.ToString();
            _aciklama = aciklama.Text.ToString();

            con.Close();
            con.Open();
            MySqlCommand smd = new MySqlCommand("SELECT uye_id FROM uyeler WHERE uye_ogrencino=@ogrno", con);
            smd.Parameters.AddWithValue("@ogrno", YetkiliGiris.gkadi);
            MySqlDataReader sr = smd.ExecuteReader();
            if (sr.Read())
            {
                _uyeid = sr["uye_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand dmd = new MySqlCommand("SELECT topluluklar_topluluk_id FROM topluluklar_has_uyeler WHERE uyeler_uye_id=@uyeid", con);
            dmd.Parameters.AddWithValue("@uyeid", _uyeid);
            MySqlDataReader dr = dmd.ExecuteReader();
            if (dr.Read())
            {
                _tid = dr["topluluklar_topluluk_id"].ToString();
            }
            con.Close();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO etkinlikler(etkinlik_adi,etkinlik_aciklamasi,etkinlik_yeri,etkinlik_tarihi,topluluklar_topluluk_id)  VALUES ('" + _adi + "' , '" + _aciklama + "' , '" + _yer + "' , '" + _tarih + "' , '" + _tid + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Etkinlik Başarıyla Oluşturuldu.", "Etkinlik Oluşturma Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Etkinlik oluşturulurken hata meydana geldi lütfen tekrar deneyin.", "Etkinlik oluşturulamadı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {
            tarih.Format = DateTimePickerFormat.Custom;
            tarih.CustomFormat = "yyyy-MM-d";
        }
    }
}
