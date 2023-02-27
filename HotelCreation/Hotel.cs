using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HotelCreation
{
    internal class Hotel
    {
        public int Floor { get; set; }
        public string Location { get; set; }
        public int RoomsPrFloor { get; set; }
        public List<MainRoom> mainRooms { get; set; } = new List<MainRoom>();
        public override string ToString()
        {
            return $"Min location {Location} | Jeg har {Floor} etager | Jeg har {RoomsPrFloor}";
        }
    }
}
