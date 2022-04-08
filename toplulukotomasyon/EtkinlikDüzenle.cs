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
    public partial class EtkinlikDüzenle : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public EtkinlikDüzenle()
        {
            InitializeComponent();
        }

        string _adi;
        string _yer;
        string _tarih;
        string _aciklama;
        string _tid;
        string _uyeid;
        string _etid;

        private void EtkinlikDüzenle_Load(object sender, EventArgs e)
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
                _tid = dr["topluluklar_topluluk_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand gmd = new MySqlCommand("SELECT *FROM etkinlikler WHERE topluluklar_topluluk_id=@tid", con);
            gmd.Parameters.AddWithValue("@tid", _tid);
            MySqlDataReader gr = gmd.ExecuteReader();
            while(gr.Read())
            {
                comboBox1.Items.Add(gr["etkinlik_adi"]);
            }
            con.Close();
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand smd = new MySqlCommand("SELECT etkinlik_id FROM etkinlikler WHERE etkinlik_adi=@etadi", con);
            smd.Parameters.AddWithValue("@etadi", comboBox1.Text);
            MySqlDataReader sr = smd.ExecuteReader();
            if (sr.Read())
            {
                 _etid = sr["etkinlik_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand gmd = new MySqlCommand("SELECT *FROM etkinlikler WHERE etkinlik_id=@etid", con);
            gmd.Parameters.AddWithValue("@etid", _etid);
            MySqlDataReader gr = gmd.ExecuteReader();
            if(gr.Read())
            {
                adi.Text = gr["etkinlik_adi"].ToString();
                aciklama.Text = gr["etkinlik_aciklamasi"].ToString();
                tarih.Text = gr["etkinlik_tarihi"].ToString();
                yer.Text = gr["etkinlik_yeri"].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _adi = adi.Text;
            _tarih = tarih.Text;
            _yer = yer.Text;
            _aciklama = aciklama.Text;

            con.Open();
            MySqlCommand dmd = new MySqlCommand("UPDATE etkinlikler SET etkinlik_adi='" + _adi + "' WHERE etkinlik_id='" + _etid + "'", con);
            dmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand amd = new MySqlCommand("UPDATE etkinlikler SET etkinlik_tarihi='" + _tarih + "' WHERE etkinlik_id='" + _etid + "'", con);
            amd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand omd = new MySqlCommand("UPDATE etkinlikler SET etkinlik_yeri='" + _yer + "' WHERE etkinlik_id='" + _etid + "'", con);
            omd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand kmd = new MySqlCommand("UPDATE etkinlikler SET etkinlik_aciklamasi='" + _aciklama + "' WHERE etkinlik_id='" + _etid + "'", con);
            kmd.ExecuteNonQuery();
            con.Close();
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {
            tarih.Format = DateTimePickerFormat.Custom;
            tarih.CustomFormat = "yyyy-MM-d";
        }
    }
}
