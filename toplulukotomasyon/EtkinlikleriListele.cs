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
    public partial class EtkinlikleriListele : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public EtkinlikleriListele()
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
        string _etsecim;

        private void EtkinlikleriListele_Load(object sender, EventArgs e)
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
            while (gr.Read())
            {
                listBox1.Items.Add(gr["etkinlik_adi"]);
            }
            con.Close();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            listBox2.Visible = true;
            textBox1.Visible = true;
            listBox2.Items.Clear();
            textBox1.Text = "";
            _etsecim = listBox1.SelectedItem.ToString();
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT etkinlik_tarihi,etkinlik_yeri,etkinlik_aciklamasi FROM etkinlikler WHERE etkinlik_adi=@etadi", con);
            hmd.Parameters.AddWithValue("@etadi", _etsecim);
            MySqlDataReader hr = hmd.ExecuteReader();
            if (hr.Read())
            {
                listBox2.Items.Add("Etkinlik Tarihi");
                listBox2.Items.Add(hr["etkinlik_tarihi"].ToString());
                listBox2.Items.Add("");
                listBox2.Items.Add("Etkinlik Yeri");
                listBox2.Items.Add(hr["etkinlik_yeri"].ToString());
                textBox1.Text = hr["etkinlik_aciklamasi"].ToString();
            }
            con.Close();
        }
    }
}
