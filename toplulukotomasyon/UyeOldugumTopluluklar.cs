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
    public partial class UyeOldugumTopluluklar : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public UyeOldugumTopluluklar()
        {
            InitializeComponent();
        }

        string _uyeid;
        string _yetkiid;
        string _toplulukid;
        string _toplulukadi;
        string _yetkiadi;

        private void UyeOldugumTopluluklar_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
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
            MySqlCommand kmd = new MySqlCommand("SELECT topluluklar_topluluk_id,uyeler_yetkiler_yetki_id FROM topluluklar_has_uyeler WHERE uyeler_uye_id=@uyeid", con);
            kmd.Parameters.AddWithValue("@uyeid", _uyeid);
            MySqlDataReader kr = kmd.ExecuteReader();
            if (kr.Read())
            {
                _toplulukid = kr["topluluklar_topluluk_id"].ToString();
                _yetkiid = kr["uyeler_yetkiler_yetki_id"].ToString();
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
                listBox1.Items.Add(_toplulukadi);
            }
            con.Close();

            con.Open();
            MySqlCommand ymd = new MySqlCommand("SELECT yetki_adi FROM yetkiler WHERE yetki_id=@ytkid", con);
            ymd.Parameters.AddWithValue("@ytkid", _yetkiid);
            MySqlDataReader yr = ymd.ExecuteReader();
            if (yr.Read())
            {
                _yetkiadi = yr["yetki_adi"].ToString();
                _yetkiadi.ToUpper().ToString();
                listBox2.Items.Add(_yetkiadi);
            }
            con.Close();




        }
    }
}
