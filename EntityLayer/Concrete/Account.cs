using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Concrete
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int PacketId { get; set; }
        public int AccountKindId { get; set; }
        public bool? Isverified { get; set; }

        public AccountKind AccountKind { get; set; }
        public Packet Packet { get; set; }
    }
}
