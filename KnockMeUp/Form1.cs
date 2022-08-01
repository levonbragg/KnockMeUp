using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.Json;

namespace KnockMeUp
{
    public partial class Form1 : Form
    {
        List<Server> serversList = new List<Server>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load JSON data from file...
            string _fileName = "servers.json";
            string[] lines = File.ReadAllLines(_fileName);
            cmbServerList.Items.Clear();
            cmbServerList.Text = "Select Server...";
            
            foreach (string line in lines)
            {
                Server server = JsonSerializer.Deserialize<Server>(line);
                serversList.Add(server);

            }
            
            foreach (Server server in serversList)
            {
                cmbServerList.Items.Add(server.Description);
            }

        }

        private void btnKnock_Click(object sender, EventArgs e)
        {
            // create a new object for testing...

            Server server = new Server(
                Guid.NewGuid().ToString(),
                "172.31.251.254",
                "Home F12",
                1,
                38617,
                "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
                1,
                10994,
                "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
                1,
                53571,
                "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
                1,
                27589,
                "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW=="
            );

            knock(server);

        }

        private void knock(Server server)
        {
            if (server is null)
            {
                throw new ArgumentNullException(nameof(server));
            }

            // send UDP test
            UdpClient udpClient = new UdpClient();

            Byte[] sendBytes = Encoding.ASCII.GetBytes(server.Packet1text);
            try
            {
                udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet1port);
            }
            catch (Exception err)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show(err.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var server = new Server
            //{
            //    ID = Guid.NewGuid().ToString(),
            //    Host = "172.31.251.254",
            //    Description = "Home F12",
            //    Packet1type = 1,
            //    Packet1port = 38617,
            //    Packet1text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
            //    Packet2type = 1,
            //    Packet2port = 10994,
            //    Packet2text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
            //    Packet3type = 1,
            //    Packet3port = 53571,
            //    Packet3text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
            //    Packet4type = 1,
            //    Packet4port = 27589,
            //    Packet4text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==",
            //};

            //string _fileName = "servers.json";
            //string jsonString = JsonSerializer.Serialize(server);
            //File.AppendAllText(_fileName, jsonString);
            
        }

        private void cmbServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHost.Text = serversList[cmbServerList.SelectedIndex].Host;
            
            txtDescription.Text = serversList[cmbServerList.SelectedIndex].Description;
            
            cmbPacket1Type.SelectedIndex = serversList[cmbServerList.SelectedIndex].Packet1type;
            cmbPacket2Type.SelectedIndex = serversList[cmbServerList.SelectedIndex].Packet2type;
            cmbPacket3Type.SelectedIndex = serversList[cmbServerList.SelectedIndex].Packet3type;
            cmbPacket4Type.SelectedIndex = serversList[cmbServerList.SelectedIndex].Packet4type;
            
            txtPacket1Port.Text = serversList[cmbServerList.SelectedIndex].Packet1port.ToString();
            txtPacket2Port.Text = serversList[cmbServerList.SelectedIndex].Packet2port.ToString();
            txtPacket3Port.Text = serversList[cmbServerList.SelectedIndex].Packet3port.ToString();
            txtPacket4Port.Text = serversList[cmbServerList.SelectedIndex].Packet4port.ToString();
            
            txtPacket1Text.Text = serversList[cmbServerList.SelectedIndex].Packet1text.ToString();
            txtPacket2Text.Text = serversList[cmbServerList.SelectedIndex].Packet2text.ToString();
            txtPacket3Text.Text = serversList[cmbServerList.SelectedIndex].Packet3text.ToString();
            txtPacket4Text.Text = serversList[cmbServerList.SelectedIndex].Packet4text.ToString();


        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            // Update selected server In the file, serversList list, and from cmbServerList
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete selected server from file, serversList list, and from cmbServerList

        }
    }
}
