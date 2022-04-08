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
    public partial class TopluluklariGoruntule : Form
    {

        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public TopluluklariGoruntule()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();
        string _tadi;

        private void TopluluklariGoruntule_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT topluluk_adi FROM topluluklar", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                topluluklar.Items.Add(dr["topluluk_adi"]);
            }
            con.Close();


        }

        private void topluluklar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tadi = Convert.ToString(topluluklar.Text);
            tablo.Clear();
            dataGridView1.DataSource = tablo;
            dataGridView1.Refresh();

            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT topluluk_aciklama,topluluk_instagram,topluluk_facebook,topluluk_twitter FROM topluluklar WHERE topluluk_adi='" + _tadi + "'", con);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Refresh();
            con.Close();
        }
    }
}
