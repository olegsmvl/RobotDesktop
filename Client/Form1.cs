using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Server;
using Newtonsoft.Json;
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            var data = new Data { Id = 1, Values = "256" };
            var jsonString = JsonConvert.SerializeObject(data);
            var body = Encoding.UTF8.GetBytes(jsonString);
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:1337/data");
            request.Method = "POST";
            request.ContentLength = body.Length;
            request.ContentType = "application/json";
            
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(body, 0, body.Length);
                dataStream.Close();
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                response.Close();
            }

        }
    }
}
