using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnockMeUp
{
    public partial class Server
    {
        public string host { get; set; }=string.Empty;
        public string description { get; set; }=string.Empty;
        public int packet1type { get; set; } = 0;
        public int packet1port { get; set; } = 0;
        public string packet1text { get; set; } = string.Empty;
        public int packet2type { get; set; } = 0;
        public int packet2port { get; set; } = 0;
        public string packet2text { get; set; } = string.Empty;
        public int packet3type { get; set; } = 0;
        public int packet3port { get; set; } = 0;
        public string packet3text { get; set; } = string.Empty;
        public int packet4type { get; set; } = 0;
        public int packet4port { get; set; } = 0;
        public string packet4text { get; set; } = string.Empty;


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

        }
    }
}
