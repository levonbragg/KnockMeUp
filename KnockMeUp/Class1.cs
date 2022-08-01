using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockMeUp
{
    public partial class Server
    {
        public string ID { get; set; } = string.Empty;
        public string Host { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
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

        public Server(string iD, string host, string description, int packet1type, int packet1port, string packet1text, int packet2type, int packet2port, string packet2text, int packet3type, int packet3port, string packet3text, int packet4type, int packet4port, string packet4text)
        {
            ID = iD;
            Host = host;
            Description = description;
            Packet1type = packet1type;
            Packet1port = packet1port;
            Packet1text = packet1text;
            Packet2type = packet2type;
            Packet2port = packet2port;
            Packet2text = packet2text;
            Packet3type = packet3type;
            Packet3port = packet3port;
            Packet3text = packet3text;
            Packet4type = packet4type;
            Packet4port = packet4port;
            Packet4text = packet4text;
        }
    }

}
