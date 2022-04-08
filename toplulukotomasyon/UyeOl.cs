using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace toplulukotomasyon
{
    public partial class UyeOl : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");

        string _ad;
        string _soyad;
        string _tcno;
        string _tarih;
        string _cinsiyet;
        string _ogrenci_no;
        string _fakulte;
        string _bolum;
        string _sinif;
        static string _telno;
        string _ogrenci_posta;
        string _kisisel_posta;
        string _adres;
        string _sifre;
        string cinsid;
        string fkltid;
        string blmid;
        string snfid;
        string yetkiid = "1";
        string _kpost;
        string _ogpost;


        public bool TcKontrol()
        {
            _tcno = uyetc.Text;
            _tcno = _tcno.Trim();
            if (_tcno.Length != 11)
            {
                uyetc.Focus();
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < _tcno.Length; i++)
            {
                sayilar[i] = Int32.Parse(_tcno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < _tcno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                return true;
            }
            else
            {
                uyetc.Focus();
                return false;
            }
        }

        private void text_Click(object sender, EventArgs e)
        {
            this.uyetc.Select(0, 0);
            this.uyetel.Select(0, 0);
        }


        public UyeOl()
        {
            InitializeComponent();
            this.uyetc.Click += new EventHandler(text_Click);
            this.uyetel.Click += new EventHandler(text_Click);
        }

        private void gerialmabutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uyead_TextChanged(object sender, EventArgs e)
        {
            uyead.Text = uyead.Text.ToUpper();
            uyead.SelectionStart = uyead.Text.Length;
        }

        private void uyesoyad_TextChanged(object sender, EventArgs e)
        {
            uyesoyad.Text = uyesoyad.Text.ToUpper();
            uyesoyad.SelectionStart = uyesoyad.Text.Length;
        }

        private void uyead_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void uyesoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void uyeogrencino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uyeolbuton_Click(object sender, EventArgs e)
        {
            _ad = Convert.ToString(uyead.Text);
            _soyad = Convert.ToString(uyesoyad.Text);
            _tcno = Convert.ToString(uyetc.Text);
            _tarih = Convert.ToString(uyedtarih.Text);
            _cinsiyet = Convert.ToString(uyecinsiyet.Text);
            _ogrenci_no = Convert.ToString(uyeogrencino.Text);
            _fakulte = Convert.ToString(fakultet.Text);
            _bolum = Convert.ToString(bolumt.Text);
            _sinif = Convert.ToString(sinift.Text);
            _telno = Convert.ToString(uyetel.Text);
            _ogrenci_posta = Convert.ToString(ogrenciposta.Text);
            _kisisel_posta = Convert.ToString(kisiselposta.Text);
            _adres = Convert.ToString(uyeadres.Text);
            _sifre = _tcno;
            _kpost = Convert.ToString(kpost.Text);
            _ogpost = Convert.ToString(ogpost.Text);
            string _ogrenciposta;
            string _kisiselposta;
            _ogrenciposta = Convert.ToString(_ogrenci_posta + _ogpost);
            _kisiselposta = Convert.ToString(_kisisel_posta + _kpost);

            if(_ad=="" || _soyad==""|| _tcno== "" || _tarih== "" || _cinsiyet==""|| _ogrenci_no==""|| _ogrenci_no==""|| _fakulte==""|| _bolum==""|| _sinif=="")
            {
                MessageBox.Show("Zorunlu Alanlar Boş Geçilemez!\nLütfen kontrol ediniz.");
            }
            if (_ad != "" && _soyad != "" && _tcno != "" && _tarih != "" && _cinsiyet != "" && _ogrenci_no != "" && _fakulte != "" && _bolum != "" && _sinif != "" && _sinif != "")
            {
                if (TcKontrol() == false)
                {
                    MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
                }
                if (TcKontrol() == true)
                {
                    con.Close();
                    con.Open();
                    MySqlCommand tkmd = new MySqlCommand("SELECT uye_tcno FROM UYELER WHERE uye_tcno=@uyetc", con);
                    tkmd.Parameters.AddWithValue("@uyetc", _tcno);
                    MySqlDataReader ter = tkmd.ExecuteReader();
                    if (ter.Read())
                    {
                        con.Close();
                        MessageBox.Show("Girilen Tc Kimlik No Zaten Kayıtlı!");
                    }
                    else
                    {
                        try
                        {
                            con.Close();
                            con.Open();
                            MySqlCommand kmd = new MySqlCommand("SELECT cinsiyet_id FROM cinsiyetler WHERE cinsiyet_adi=@cinsiyet", con);
                            kmd.Parameters.AddWithValue("@cinsiyet", uyecinsiyet.Text);
                            MySqlDataReader er = kmd.ExecuteReader();
                            if (er.Read())
                            {
                                cinsid = er["cinsiyet_id"].ToString();
                            }
                            con.Close();
                            con.Open();
                            MySqlCommand hmd = new MySqlCommand("SELECT fakulte_id FROM fakulteler WHERE fakulte_adi=@fakulte", con);
                            hmd.Parameters.AddWithValue("@fakulte", fakultet.Text);
                            MySqlDataReader cr = hmd.ExecuteReader();
                            if (cr.Read())
                            {
                                fkltid = cr["fakulte_id"].ToString();
                            }
                            con.Close();
                            con.Open();
                            MySqlCommand jmd = new MySqlCommand("SELECT bolum_id FROM bolumler WHERE bolum_adi=@bolum and fakulteler_fakulte_id=@fakulte", con);
                            jmd.Parameters.AddWithValue("@bolum", bolumt.Text);
                            jmd.Parameters.AddWithValue("@fakulte", fkltid);
                            MySqlDataReader jr = jmd.ExecuteReader();
                            if (jr.Read())
                            {
                                blmid = jr["bolum_id"].ToString();
                            }
                            con.Close();
                            con.Open();
                            MySqlCommand lmd = new MySqlCommand("SELECT sinif_id FROM siniflar WHERE sinif_adi=@sinif and bolumler_bolum_id=@bolum and bolumler_fakulteler_fakulte_id=@fakulte", con);
                            lmd.Parameters.AddWithValue("@sinif", sinift.Text);
                            lmd.Parameters.AddWithValue("@bolum", blmid);
                            lmd.Parameters.AddWithValue("@fakulte", fkltid);
                            MySqlDataReader lr = lmd.ExecuteReader();
                            if (lr.Read())
                            {
                                snfid = lr["sinif_id"].ToString();
                            }
                            con.Close();
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO uyeler(uye_adi,uye_soyadi,uye_dtarih,uye_tcno,uye_ogrencino,uye_tel,uye_ogrenciposta,uye_kisiselposta,uye_adres,uye_sifre,siniflar_sinif_id,siniflar_bolumler_bolum_id,siniflar_bolumler_fakulteler_fakulte_id,cinsiyetler_cinsiyet_id,yetkiler_yetki_id)  VALUES ('" + _ad + "' , '" + _soyad + "' , '" + _tarih + "' , '" + _tcno + "' , '" + _ogrenci_no + "' , '" + _telno + "' , '" + _ogrenciposta + "' , '" + _kisiselposta + "' , '" + _adres + "' , '" + _sifre + "' , '" + snfid + "' , '" + blmid + "' , '" + fkltid + "' , '" + cinsid + "' , '" + yetkiid + "')", con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Üye Kaydınız Başarılı. Şifreniz TC kimlik numaranız, kullanıcı adınız öğrenci numaranızdır.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            this.Dispose();


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Kayıt İşlemi Sırasında Hata Oluştu. Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("TC Kimlik Numarası Hatalı.Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }


        private void UyeOl_Load(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT fakulte_adi FROM fakulteler", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fakultet.Items.Add(dr["fakulte_adi"]);
            }
            con.Close();
            con.Open();
            MySqlCommand kmd = new MySqlCommand("SELECT cinsiyet_adi FROM cinsiyetler", con);
            MySqlDataReader kr = kmd.ExecuteReader();
            while (kr.Read())
            {
                uyecinsiyet.Items.Add(kr["cinsiyet_adi"]);
            }
            con.Close();
        }

        private void bolumt_Click(object sender, EventArgs e)
        {
            if (fakultet.Text == "")
            {
                MessageBox.Show("Lütfen Fakülte Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void sinift_Click(object sender, EventArgs e)
        {
            if (bolumt.Text == "")
            {
                MessageBox.Show("Lütfen Bölüm Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void fakultet_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                bolumt.Items.Clear();
                bolumt.Text = "";
                sinift.Items.Clear();
                sinift.Text = "";

                string gelendeger;
                con.Open();
                MySqlCommand kmd = new MySqlCommand("SELECT fakulte_id FROM fakulteler WHERE fakulte_adi=@fakulte", con);
                kmd.Parameters.AddWithValue("@fakulte", fakultet.Text);
                MySqlDataReader kr = kmd.ExecuteReader();
                kr.Read();
                gelendeger = kr["fakulte_id"].ToString();
                con.Close();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT bolum_adi FROM bolumler WHERE fakulteler_fakulte_id=@fakulte", con);
                cmd.Parameters.AddWithValue("@fakulte", gelendeger);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bolumt.Items.Add(dr["bolum_adi"]);
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Fakülte Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void bolumt_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bolumt.Text != "")
            {
                try
                {
                    sinift.Text = "";
                    sinift.Items.Clear();


                    string gelendeger;
                    con.Open();
                    MySqlCommand kmd = new MySqlCommand("SELECT bolum_id FROM bolumler WHERE bolum_adi=@bolum", con);
                    kmd.Parameters.AddWithValue("@bolum", bolumt.Text);
                    MySqlDataReader kr = kmd.ExecuteReader();
                    kr.Read();
                    gelendeger = kr["bolum_id"].ToString();
                    con.Close();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT sinif_adi FROM siniflar WHERE bolumler_bolum_id=@bolum", con);
                    cmd.Parameters.AddWithValue("@bolum", gelendeger);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        sinift.Items.Add(dr["sinif_adi"]);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Bölüm Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void uyedtarih_ValueChanged(object sender, EventArgs e)
        {
            uyedtarih.Format = DateTimePickerFormat.Custom;
            uyedtarih.CustomFormat = "yyyy-MM-d";
        }
    }
}
