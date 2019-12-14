﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClientProject
{
    public partial class FormTCPClient : Form
    {
        private string Message = string.Empty;
        public FormTCPClient()
        {
            InitializeComponent();

            
        }

        private void FormTCPClient_Shown(object sender, EventArgs e)
        {
            Task task = Task.Run(() => {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect("192.168.1.94", 5051);
                var stream = tcpClient.GetStream();

                while (true)
                {
                    if (stream.DataAvailable)
                    {
                        byte[] data = new byte[256];
                        int bytes = stream.Read(data, 0, data.Length);
                        Message += Encoding.UTF8.GetString(data, 0, bytes);
                        tbData.Invoke(new Action<string>((s) => tbData.Text = s), Message);
                    }
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbData.Text = Message;
        }
    }
}