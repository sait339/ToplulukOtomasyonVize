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
    public partial class ToplulukUyelerListele : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public ToplulukUyelerListele()
        {
            InitializeComponent();
        }

        string _toplulukid;
        string _uyeid;
        string _uid;
        string _yetkiid;
        string _uyead;
        string _uyesoyad;
        string _uyeyetki;
        string _ogrencino;
        List<string> uyeidler = new List<string>();
        List<string> yetkiidler = new List<string>();

        private void ToplulukUyelerListele_Load(object sender, EventArgs e)
        {
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
                _toplulukid = dr["topluluklar_topluluk_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand tmd = new MySqlCommand("SELECT uyeler_uye_id,uyeler_yetkiler_yetki_id FROM topluluklar_has_uyeler WHERE topluluklar_topluluk_id=@tid", con);
            tmd.Parameters.AddWithValue("@tid", _toplulukid);
            MySqlDataReader tr = tmd.ExecuteReader();
            while (tr.Read())
            {
                _uid = tr["uyeler_uye_id"].ToString();
                _yetkiid = tr["uyeler_yetkiler_yetki_id"].ToString();

                uyeidler.Add(_uid);
                yetkiidler.Add(_yetkiid);
            }
            con.Close();

            foreach (string uidler in uyeidler)
            {
                con.Open();
                MySqlCommand umd = new MySqlCommand("SELECT uye_adi,uye_soyadi,uye_ogrencino FROM uyeler WHERE uye_id=@uyeid", con);
                umd.Parameters.AddWithValue("@uyeid", uidler);
                MySqlDataReader ur = umd.ExecuteReader();
                if (ur.Read())
                {
                    _uyead = ur["uye_adi"].ToString();
                    _uyesoyad = ur["uye_soyadi"].ToString();
                    _ogrencino = ur["uye_ogrencino"].ToString();

                }
                listBox1.Items.Add(_uyead+ " " + _uyesoyad);
                listBox3.Items.Add(_ogrencino);
                con.Close();
            }

            foreach (string yidler in yetkiidler)
            {
                con.Open();
                MySqlCommand ymd = new MySqlCommand("SELECT yetki_adi FROM yetkiler WHERE yetki_id=@ytkid", con);
                ymd.Parameters.AddWithValue("@ytkid", yidler);
                MySqlDataReader yr = ymd.ExecuteReader();
                if (yr.Read())
                {
                    _uyeyetki = yr["yetki_adi"].ToString();
                }
                listBox2.Items.Add(_uyeyetki);
                con.Close();
            }

            con.Open();
            MySqlCommand jmd = new MySqlCommand("SELECT yetki_adi FROM yetkiler", con);
            MySqlDataReader jr = jmd.ExecuteReader();
            while(jr.Read())
            {
                comboBox1.Items.Add(jr["yetki_adi"]).ToString();
            }
            con.Close();
        }


        string _ad;
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            comboBox1.Visible = true;

            _ad = listBox3.SelectedItem.ToString();
        }
        string uuid;
        string _yetkid;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand jmd = new MySqlCommand("SELECT yetki_id FROM yetkiler WHERE yetki_adi=@ytkadi", con);
            jmd.Parameters.AddWithValue("@ytkadi", comboBox1.Text);
            MySqlDataReader jr = jmd.ExecuteReader();
            if (jr.Read())
            {
                _yetkid = jr["yetki_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand dmd = new MySqlCommand("UPDATE uyeler SET yetkiler_yetki_id='" + _yetkid + "' WHERE uye_ogrencino='" + _ad + "'", con);
            dmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            MySqlCommand amd = new MySqlCommand("SELECT uye_id FROM uyeler WHERE uye_ogrencino=@ogrno", con);
            amd.Parameters.AddWithValue("@ogrno", _ad);
            MySqlDataReader ar = amd.ExecuteReader();
            if (ar.Read())
            {
                uuid= ar["uye_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand imd = new MySqlCommand("UPDATE topluluklar_has_uyeler SET uyeler_yetkiler_yetki_id='" + _yetkid + "' WHERE uyeler_uye_id='" + uuid + "'", con);
            imd.ExecuteNonQuery();
            con.Close();
        }
    }
}
