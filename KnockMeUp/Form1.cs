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

namespace KnockMeUp
{
    public partial class Server
    {
        public string Host { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public int Packet1type { get; set; } = 0;
        public int Packet1port { get; set; } = 0;
        public string Packet1text { get; set; } = string.Empty;
        public int Packet2type { get; set; } = 0;
        public int Packet2port { get; set; } = 0;
        public string Packet2text { get; set; } = string.Empty;
        public int Packet3type { get; set; } = 0;
        public int Packet3port { get; set; } = 0;
        public string Packet3text { get; set; } = string.Empty;
        public int Packet4type { get; set; } = 0;
        public int Packet4port { get; set; } = 0;
        public string Packet4text { get; set; } = string.Empty;


    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKnock_Click(object sender, EventArgs e)
        {
            // create a new object for testing...

            Server server = new Server();
            server.Host = "172.31.251.254";
            server.Description = "Home F12";
            server.Packet1type = 1;
            server.Packet1port = 38617;
            server.Packet1text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==";
            server.Packet2type = 1;
            server.Packet2port = 10994;
            server.Packet2text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==";
            server.Packet3type = 1;
            server.Packet3port = 53571;
            server.Packet3text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==";
            server.Packet4type = 1;
            server.Packet4port = 27589;
            server.Packet4text = "Gd57xb1zNlQvedtUuP14qa3eWka618TjLhVvvTCW==";

            knock(server);

        }

        private void knock (Server server)
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
            }


        }
    }
}
