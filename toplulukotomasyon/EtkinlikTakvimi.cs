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
    public partial class EtkinlikTakvimi : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public EtkinlikTakvimi()
        {
            InitializeComponent();
        }

        string _uyeid;
        string _toplulukid;
        string _toplulukadi;
        string _secimid;
        string _secimadi;
        string _etsecim;

        private void EtkinlikTakvimi_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT uye_id FROM uyeler WHERE uye_ogrencino=@ogrno", con);
            hmd.Parameters.AddWithValue("@ogrno", UyeGiris.gkadi);
            MySqlDataReader hr = hmd.ExecuteReader();
            if (hr.Read())
            {
                _uyeid = hr["uye_id"].ToString();
            }
            con.Close();
            con.Open();
            MySqlCommand kmd = new MySqlCommand("SELECT topluluklar_topluluk_id FROM topluluklar_has_uyeler WHERE uyeler_uye_id=@uyeid", con);
            kmd.Parameters.AddWithValue("@uyeid", _uyeid);
            MySqlDataReader kr = kmd.ExecuteReader();
            if (kr.Read())
            {
                _toplulukid = kr["topluluklar_topluluk_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand tmd = new MySqlCommand("SELECT topluluk_adi FROM topluluklar WHERE topluluk_id=@tplkid", con);
            tmd.Parameters.AddWithValue("@tplkid", _toplulukid);
            MySqlDataReader tr = tmd.ExecuteReader();
            if (tr.Read())
            {
                _toplulukadi = tr["topluluk_adi"].ToString();
                _toplulukadi.ToUpper().ToString();
                comboBox1.Items.Add(_toplulukadi);
            }
            con.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            label2.Visible = true;
            listBox1.Items.Clear();
            _secimadi = comboBox1.Text;
            con.Open();
            MySqlCommand kmd = new MySqlCommand("SELECT topluluk_id FROM topluluklar WHERE topluluk_adi=@tadi", con);
            kmd.Parameters.AddWithValue("@tadi", _secimadi);
            MySqlDataReader kr = kmd.ExecuteReader();
            if (kr.Read())
            {
                _secimid = kr["topluluk_id"].ToString();
            }
            con.Close();
            con.Open();
            MySqlCommand hmd = new MySqlCommand("SELECT etkinlik_adi FROM etkinlikler WHERE topluluklar_topluluk_id=@tid", con);
            hmd.Parameters.AddWithValue("@tid", _secimid);
            MySqlDataReader hr = hmd.ExecuteReader();
            while (hr.Read())
            {
                listBox1.Items.Add(hr["etkinlik_adi"].ToString());
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
