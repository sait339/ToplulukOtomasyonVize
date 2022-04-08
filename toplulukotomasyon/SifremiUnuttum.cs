using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace toplulukotomasyon
{
    public partial class SifremiUnuttum : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;port=3306;Database=toplulukdb;user=root;password=admin;SslMode=none;");
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string XMLPOST(string PostAddress, string xmlData)
        {
            try
            {
                var res = "";
                byte[] bytes = Encoding.UTF8.GetBytes(xmlData);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(PostAddress);

                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/xml";
                request.Timeout = 300000000;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                // This sample only checks whether we get an "OK" HTTP status code back.
                // If you must process the XML-based response, you need to read that from
                // the response stream.
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format(
                        "POST failed. Received HTTP {0}",
                        response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader rdr = new StreamReader(responseStream))
                    {
                        res = rdr.ReadToEnd();
                    }
                    return res;
                }
            }
            catch
            {

                return "-1";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                int ascii = rastgele.Next(32, 127);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);

            }
            Console.WriteLine(sb.ToString());

            String testXml = "<request>";
            testXml += "<authentication>";
            testXml += "<username>Muhammet Sait Kocabaş</username>";
            testXml += "<password>54844255s.</password>";
            testXml += "</authentication>";
            testXml += "<order>";
            testXml += "<sender>ProBit</sender>";
            testXml += "<sendDateTime></sendDateTime>";
            testXml += "<message>";
            testXml += "<text>" + sb.ToString() + "</text>";
            testXml += "<receipents>";
            testXml += "<number>5356445375</number>";
            testXml += "</receipents>";
            testXml += "</message>";
            testXml += "</order>";
            testXml += "</request>";

            this.XMLPOST("http://api.iletimerkezi.com/v1/send-sms", testXml);



        }

    }
}
