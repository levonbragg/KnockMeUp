using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Net.Sockets;
using System.Text.Json;
using SuperSimpleTcp;
using System.Threading;


namespace KnockMeUp
{    
    public partial class Form1 : Form
    {
        private static System.Timers.Timer keepAliveTimer;
        List<Server> serversList = new List<Server>();
        bool reload = false;
        int KeepAliveSentCounter=0;
        Server KeepAliveServer;
        delegate void SetTextCallback(string text);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKeepAlivesSent.Text="";
            LoadServerData();
        }

        private void LoadServerData()
        {
            cmbServerList.Items.Clear();
            cmbServerList.Text = "Add a Server...";
            serversList.Clear();

            // Load JSON data from file if there is one...
            string _fileName = "servers.json";
            try
            {
                string[] lines = File.ReadAllLines(_fileName);
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
            catch (FileNotFoundException err)
            {
                // File does not exist, so lets create one...
                File.WriteAllText(_fileName, string.Empty);
            }
                       
            if (cmbServerList.Items.Count > 0)
            {                
                cmbServerList.SelectedIndex = 0;
            }
            else
            {
                // No servers saved yet, so...
                // Setup form for a new record.
                txtID.Text = Guid.NewGuid().ToString();
                txtHost.Text = string.Empty;
                txtDescription.Text = string.Empty;

                cmbPacket1Type.SelectedIndex = 0;
                cmbPacket2Type.SelectedIndex = 0;
                cmbPacket3Type.SelectedIndex = 0;
                cmbPacket4Type.SelectedIndex = 0;

                txtPacket1Port.Text = "0";
                txtPacket2Port.Text = "0";
                txtPacket3Port.Text = "0";
                txtPacket4Port.Text = "0";

                txtPacket1Text.Text = string.Empty;
                txtPacket2Text.Text = string.Empty;
                txtPacket3Text.Text = string.Empty;
                txtPacket4Text.Text = string.Empty;
            }
            
        }

        private void btnKnock_Click(object sender, EventArgs e)
        {
            if (cmbServerList.SelectedIndex != -1)
            {
                Server server = new Server(
                    serversList[cmbServerList.SelectedIndex].ID,
                    serversList[cmbServerList.SelectedIndex].Host,
                    serversList[cmbServerList.SelectedIndex].Description,
                    serversList[cmbServerList.SelectedIndex].Packet1type,
                    serversList[cmbServerList.SelectedIndex].Packet1port,
                    serversList[cmbServerList.SelectedIndex].Packet1text,
                    serversList[cmbServerList.SelectedIndex].Packet2type,
                    serversList[cmbServerList.SelectedIndex].Packet2port,
                    serversList[cmbServerList.SelectedIndex].Packet2text,
                    serversList[cmbServerList.SelectedIndex].Packet3type,
                    serversList[cmbServerList.SelectedIndex].Packet3port,
                    serversList[cmbServerList.SelectedIndex].Packet3text,
                    serversList[cmbServerList.SelectedIndex].Packet4type,
                    serversList[cmbServerList.SelectedIndex].Packet4port,
                    serversList[cmbServerList.SelectedIndex].Packet4text
                    );

                
                if (server != null)
                {
                    if (chkKeepAlive.Checked)
                    {
                        KeepAliveServer = server;
                        keepAliveTimer = new System.Timers.Timer((Convert.ToDouble(txtSeconds.Text))*1000);
                        lblKeepAlivesSent.Text = string.Empty;
                        KeepAliveSentCounter=0;
                        keepAliveTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                        keepAliveTimer.Start();
                    }
                    knock(server);
                }
            }
            else
            {
                MessageBox.Show(this,"Select Server First!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            

        }

        private void OnTimedEvent(object? sender, ElapsedEventArgs e)
        {
            if (KeepAliveServer != null && chkKeepAlive.Checked)
            {
                knock(KeepAliveServer);
                KeepAliveSentCounter++;
                string kas = KeepAliveSentCounter.ToString();
                if (lblKeepAlivesSent.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { kas });
                    
                }

            }
            else
            {
                keepAliveTimer.Stop();
            }
        }

        private void SetText(string text)
        {
            this.lblKeepAlivesSent.Text=text;
        }


        private void knock(Server server)
        {
            int milliseconds = 100;
            
            if (server is null)
            {
                throw new ArgumentNullException(nameof(server));
            }
                        
            UdpClient udpClient = new UdpClient();

            if(server.Packet1type !=0)
            {
                
                switch(server.Packet1type)
                {
                    case 1:
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(server.Packet1text);
                        try
                        {
                            udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet1port);
                            Thread.Sleep(milliseconds);
                            if (chkDuplicate.Checked)
                            {
                                udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet1port);
                            }
                        }
                        catch (Exception err)
                        {                            
                            MessageBox.Show(err.Message);
                        }
                        break;
                    
                    case 2:
                        // Send a TCP packet
                        // instantiate
                        SimpleTcpClient client = new SimpleTcpClient(txtHost.Text+":"+txtPacket1Port.Text);


                        // set events
                        //client.Events.Connected += Connected;
                        //client.Events.Disconnected += Disconnected;
                        //client.Events.DataReceived += DataReceived;

                        // let's go!
                        try
                        {
                            //client.Connect();
                            client.ConnectWithRetries(10);
                        }
                        catch(System.Net.Sockets.SocketException ex)
                        {

                        }
                        catch(System.TimeoutException ex1)
                        {

                        }
                        break;
                                        
                    default:

                        break;
                        
                }
            }
            if (server.Packet2type != 0)
            {

                switch (server.Packet2type)
                {
                    case 1:
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(server.Packet2text);
                        try
                        {
                            udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet2port);
                            Thread.Sleep(milliseconds);
                            if (chkDuplicate.Checked)
                            {
                                udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet2port);
                            }
                        }
                        catch (Exception err)
                        {
                            //Console.WriteLine(e.ToString());
                            MessageBox.Show(err.Message);
                        }
                        break;

                    case 2:
                        // Send a TCP packet
                        // instantiate
                        SimpleTcpClient client = new SimpleTcpClient(txtHost.Text + ":" + txtPacket2Port.Text);

                        // set events
                        //client.Events.Connected += Connected;
                        //client.Events.Disconnected += Disconnected;
                        //client.Events.DataReceived += DataReceived;

                        // let's go!
                        try
                        {
                            //client.Connect();
                            client.ConnectWithRetries(20);
                        }
                        catch (System.Net.Sockets.SocketException ex)
                        {

                        }
                        catch (System.TimeoutException ex1)
                        {

                        }

                        break;

                    default:

                        break;

                }
            }
            if (server.Packet3type != 0)
            {

                switch (server.Packet3type)
                {
                    case 1:
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(server.Packet3text);
                        try
                        {
                            udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet3port);
                            Thread.Sleep(milliseconds);
                            if (chkDuplicate.Checked)
                            {
                                udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet3port);
                            }
                        }
                        catch (Exception err)
                        {
                            //Console.WriteLine(e.ToString());
                            MessageBox.Show(err.Message);
                        }
                        break;

                    case 2:
                        // Send a TCP packet
                        // instantiate
                        SimpleTcpClient client = new SimpleTcpClient(txtHost.Text + ":" + txtPacket3Port.Text);

                        // set events
                        //client.Events.Connected += Connected;
                        //client.Events.Disconnected += Disconnected;
                        //client.Events.DataReceived += DataReceived;

                        // let's go!
                        try
                        {
                            //client.Connect();
                            client.ConnectWithRetries(20);
                        }
                        catch (System.Net.Sockets.SocketException ex)
                        {

                        }
                        catch (System.TimeoutException ex1)
                        {

                        }

                        break;

                    default:

                        break;

                }
            }
            if (server.Packet4type != 0)
            {

                switch (server.Packet4type)
                {
                    case 1:
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(server.Packet4text);
                        try
                        {
                            udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet4port);
                            Thread.Sleep(milliseconds);
                            if (chkDuplicate.Checked)
                            {
                                udpClient.Send(sendBytes, sendBytes.Length, server.Host, server.Packet4port);
                            }

                        }
                        catch (Exception err)
                        {
                            //Console.WriteLine(e.ToString());
                            MessageBox.Show(err.Message);
                        }
                        break;

                    case 2:
                        // Send a TCP packet
                        // instantiate
                        SimpleTcpClient client = new SimpleTcpClient(txtHost.Text + ":" + txtPacket4Port.Text);

                        // set events
                        //client.Events.Connected += Connected;
                        //client.Events.Disconnected += Disconnected;
                        //client.Events.DataReceived += DataReceived;

                        // let's go!
                        try
                        {
                            //client.Connect();
                            client.ConnectWithRetries(20);
                        }
                        catch (System.Net.Sockets.SocketException ex)
                        {

                        }
                        catch (System.TimeoutException ex1)
                        {

                        }

                        break;

                    default:

                        break;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
        }

        private void cmbServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServerList.SelectedIndex != -1)
            {
                txtID.Text = serversList[cmbServerList.SelectedIndex].ID;
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
            else
            {
                // Selected index == -1 so clear the form
                txtID.Text = Guid.NewGuid().ToString();
                txtHost.Text = string.Empty;
                txtDescription.Text = string.Empty;

                cmbPacket1Type.SelectedIndex = 0;
                cmbPacket2Type.SelectedIndex = 0;
                cmbPacket3Type.SelectedIndex = 0;
                cmbPacket4Type.SelectedIndex = 0;

                txtPacket1Port.Text = "0";
                txtPacket2Port.Text = "0";
                txtPacket3Port.Text = "0";
                txtPacket4Port.Text = "0";

                txtPacket1Text.Text = string.Empty;
                txtPacket2Text.Text = string.Empty;
                txtPacket3Text.Text = string.Empty;
                txtPacket4Text.Text = string.Empty;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            // Find and update the item in the List
            var item = serversList.FirstOrDefault(o => o.ID == txtID.Text);
            if (item != null)
            {
                try
                {
                    item.ID = txtID.Text;
                    item.Host = txtHost.Text;
                    item.Description = txtDescription.Text;
                    item.Packet1type = cmbPacket1Type.SelectedIndex;
                    item.Packet1port = Convert.ToInt32(txtPacket1Port.Text);
                    item.Packet1text = txtPacket1Text.Text;
                    item.Packet2type = cmbPacket2Type.SelectedIndex;
                    item.Packet2port = Convert.ToInt32(txtPacket2Port.Text);
                    item.Packet2text = txtPacket2Text.Text;
                    item.Packet3type = cmbPacket3Type.SelectedIndex;
                    item.Packet3port = Convert.ToInt32(txtPacket3Port.Text);
                    item.Packet3text = txtPacket3Text.Text;
                    item.Packet4type = cmbPacket4Type.SelectedIndex;
                    item.Packet4port = Convert.ToInt32(txtPacket4Port.Text);
                    item.Packet4text = txtPacket4Text.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //Adding new item
                reload = true;
                Server server = new Server(
                    txtID.Text,
                    txtHost.Text,
                    txtDescription.Text,
                    cmbPacket1Type.SelectedIndex,
                    txtPacket1Port.Text == "" ? 0 : Convert.ToInt32(txtPacket1Port.Text),
                    txtPacket1Text.Text,
                    cmbPacket2Type.SelectedIndex,
                    txtPacket2Port.Text == "" ? 0 : Convert.ToInt32(txtPacket2Port.Text),
                    txtPacket2Text.Text,
                    cmbPacket3Type.SelectedIndex,
                    txtPacket3Port.Text == "" ? 0 : Convert.ToInt32(txtPacket3Port.Text),
                    txtPacket3Text.Text,
                    cmbPacket4Type.SelectedIndex,
                    txtPacket4Port.Text == "" ? 0 : Convert.ToInt32(txtPacket4Port.Text),
                    txtPacket4Text.Text
                    );
               
                serversList.Add(server);

            }

            // Write new file from data in memory. Could probably just update the single line in the file... but...
            string _fileName = "servers.json";
            string jsonString = string.Empty;
            File.WriteAllText(_fileName, string.Empty);

            foreach (Server server in serversList)
            {
                jsonString = JsonSerializer.Serialize(server);
                File.AppendAllText(_fileName, jsonString+"\r\n");
                
            }

            if (reload == true)
            {
                reload = false;
                LoadServerData();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var item = serversList.SingleOrDefault(o => o.ID == txtID.Text);
            if (item != null)
            {
                serversList.Remove(item);
            }
            // Write new file from data in memory. Could probably just update the single line in the file... but...
            string _fileName = "servers.json";
            string jsonString = string.Empty;
            File.WriteAllText(_fileName, string.Empty);

            foreach (Server server in serversList)
            {
                jsonString = JsonSerializer.Serialize(server);
                File.AppendAllText(_fileName, jsonString + "\r\n");

            }

            LoadServerData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbServerList.SelectedIndex = -1;
        }

        static void Connected(object sender, ConnectionEventArgs e)
        {
            //Console.WriteLine($"*** Server {e.IpPort} connected");
        }

        static void Disconnected(object sender, ConnectionEventArgs e)
        {
            //Console.WriteLine($"*** Server {e.IpPort} disconnected");
        }

        static void DataReceived(object sender, DataReceivedEventArgs e)
        {
            //Console.WriteLine($"[{e.IpPort}] {Encoding.UTF8.GetString(e.Data)}");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (keepAliveTimer !=null && keepAliveTimer.Enabled)
            {
                keepAliveTimer.Stop();
            }
            
        }
    }
}
