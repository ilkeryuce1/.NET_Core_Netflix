using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccountKind
    {
        [Key]
        public int AccounKindtId { get; set; }
        public string AccounName { get; set; }
    }
}
