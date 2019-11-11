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
            var request = WebRequest.Create("http://localhost:1337/data/test");
            var responce = request.GetResponse();
        }
    }
}
