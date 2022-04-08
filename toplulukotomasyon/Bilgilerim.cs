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
    public partial class Bilgilerim : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public Bilgilerim()
        {
            InitializeComponent();
        }

        string _ad;
        string _soyad;
        string _tcno;
        string _tarih;
        string _cinsiyet;
        string _fakulte;
        string _bolum;
        string _sinif;
        string _telno;
        string _ogrenci_posta;
        string _kisisel_posta;
        string _adres;
        string cinsid;
        string fkltid;
        string blmid;
        string snfid;

        private void Bilgilerim_Load(object sender, EventArgs e)
        {
            

            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM uyeler WHERE uye_ogrencino=@gkadi", con);
            cmd.Parameters.AddWithValue("@gkadi",UyeGiris.gkadi);
            MySqlDataReader kr = cmd.ExecuteReader();
            if (kr.Read())
            {
                _ad = kr["uye_adi"].ToString();
                _soyad = kr["uye_soyadi"].ToString();
                _tcno = kr["uye_tcno"].ToString();
                _tarih = kr["uye_dtarih"].ToString();
                _telno = kr["uye_tel"].ToString();
                _ogrenci_posta = kr["uye_ogrenciposta"].ToString();
                _kisisel_posta = kr["uye_kisiselposta"].ToString();
                _adres = kr["uye_adres"].ToString();
                fkltid = kr["siniflar_bolumler_fakulteler_fakulte_id"].ToString();
                blmid = kr["siniflar_bolumler_bolum_id"].ToString();
                snfid = kr["siniflar_sinif_id"].ToString();
                cinsid = kr["cinsiyetler_cinsiyet_id"].ToString();
                con.Close();
                con.Open();
                MySqlCommand hmd = new MySqlCommand("SELECT fakulte_adi FROM fakulteler WHERE fakulte_id=@fkltid",con);
                hmd.Parameters.AddWithValue("@fkltid", fkltid);
                MySqlDataReader hr = hmd.ExecuteReader();
                if (hr.Read())
                {
                    _fakulte = hr["fakulte_adi"].ToString();
                    fakultet.Text = _fakulte;
                }
                con.Close();
                con.Open();
                MySqlCommand bmd = new MySqlCommand("SELECT bolum_adi FROM bolumler WHERE bolum_id=@blmid", con);
                bmd.Parameters.AddWithValue("@blmid", blmid);
                MySqlDataReader br = bmd.ExecuteReader();
                if (br.Read())
                {
                    _bolum = br["bolum_adi"].ToString();
                    bolumt.Text = _bolum;
                }
                con.Close();
                con.Open();
                MySqlCommand smd = new MySqlCommand("SELECT sinif_adi FROM siniflar WHERE sinif_id=@snfid", con);
                smd.Parameters.AddWithValue("@snfid", snfid);
                MySqlDataReader sr = smd.ExecuteReader();
                if (sr.Read())
                {
                    _sinif = sr["sinif_adi"].ToString();
                    sinift.Text = _sinif;
                }
                con.Close();
                con.Open();
                MySqlCommand fmd = new MySqlCommand("SELECT cinsiyet_adi FROM cinsiyetler WHERE cinsiyet_id=@cnsid", con);
                fmd.Parameters.AddWithValue("@cnsid", cinsid);
                MySqlDataReader fr = fmd.ExecuteReader();
                if (fr.Read())
                {
                    _cinsiyet = fr["cinsiyet_adi"].ToString();
                    cinsiyet.Text = _cinsiyet;
                }
                con.Close();
                uyead.Text = _ad;
                uyesoyad.Text = _soyad;
                tarih.Text = _tarih;
                uyetc.Text = _tcno;
                ogrno.Text = UyeGiris.gkadi;
                telno.Text = _telno;
                adres.Text = _adres;
                kposta.Text = _kisisel_posta;
                ogposta.Text = _ogrenci_posta;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _telno = telno.Text;
            _adres = adres.Text;
            _kisisel_posta = kposta.Text;
            _ogrenci_posta = ogposta.Text;

            con.Open();
            MySqlCommand dmd = new MySqlCommand("UPDATE uyeler SET uye_tel='" + _telno + "' WHERE uye_ogrencino='" + UyeGiris.gkadi + "'", con);
            dmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand amd = new MySqlCommand("UPDATE uyeler SET uye_adres='" + _adres + "' WHERE uye_ogrencino='" + UyeGiris.gkadi + "'", con);
            amd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand omd = new MySqlCommand("UPDATE uyeler SET uye_ogrenciposta='" + _ogrenci_posta + "' WHERE uye_ogrencino='" + UyeGiris.gkadi + "'", con);
            omd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand kmd = new MySqlCommand("UPDATE uyeler SET uye_kisiselposta='" + _kisisel_posta + "' WHERE uye_ogrencino='" + UyeGiris.gkadi + "'", con);
            kmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
