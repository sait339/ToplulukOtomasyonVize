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
    public partial class ToplulukBilgileri : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public ToplulukBilgileri()
        {
            InitializeComponent();
        }

        string _uyeid;
        string _toplulukid;
        string _tadi;
        string _taciklama;
        string _tinstagram;
        string _tfacebook;
        string _ttwitter;

        private void button1_Click(object sender, EventArgs e)
        {
            _tadi = tad.Text;
            _tinstagram = tinst.Text;
            _tfacebook = tface.Text;
            _ttwitter = ttwit.Text;
            _taciklama = thak.Text;

            con.Open();
            MySqlCommand mmd = new MySqlCommand("UPDATE topluluklar SET topluluk_adi='" + _tadi + "' WHERE topluluk_id='" + _toplulukid + "'", con);
            mmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand amd = new MySqlCommand("UPDATE topluluklar SET topluluk_aciklama='" + _taciklama + "' WHERE topluluk_id='" + _toplulukid + "'", con);
            amd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand omd = new MySqlCommand("UPDATE topluluklar SET topluluk_instagram='" + _tinstagram+ "' WHERE topluluk_id='" + _toplulukid + "'", con);
            omd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand kmd = new MySqlCommand("UPDATE topluluklar SET topluluk_facebook='" + _tfacebook+ "' WHERE topluluk_id='" + _toplulukid + "'", con);
            kmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            MySqlCommand lmd = new MySqlCommand("UPDATE topluluklar SET topluluk_twitter='" + _ttwitter + "' WHERE topluluk_id='" + _toplulukid + "'", con);
            lmd.ExecuteNonQuery();
            con.Close();
        }

        private void ToplulukBilgileri_Load(object sender, EventArgs e)
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
            dmd.Parameters.AddWithValue("@uyeid",_uyeid );
            MySqlDataReader dr = dmd.ExecuteReader();
            if (dr.Read())
            {
                _toplulukid = dr["topluluklar_topluluk_id"].ToString();
            }
            con.Close();

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM topluluklar WHERE topluluk_id=@tid", con);
            cmd.Parameters.AddWithValue("@tid", _toplulukid);
            MySqlDataReader cr = cmd.ExecuteReader();
            if (cr.Read())
            {
                _tadi = cr["topluluk_adi"].ToString();
                _taciklama = cr["topluluk_aciklama"].ToString();
                _tfacebook = cr["topluluk_facebook"].ToString();
                _tinstagram = cr["topluluk_instagram"].ToString();
                _ttwitter= cr["topluluk_twitter"].ToString();

                tad.Text = _tadi;
                thak.Text = _taciklama;
                tinst.Text = _tinstagram;
                tface.Text = _tfacebook;
                ttwit.Text = _ttwitter;
            }
            con.Close();
        }
    }
}
