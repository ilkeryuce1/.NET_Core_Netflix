using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Packet
    {
        [Key]
        public int PacketId { get; set; }
        public string PacketName { get; set; }
        public int AccountOdUserCount { get; set; }
        public float Price { get; set; }
    }
}
