using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MovieKind
    {
        [Key]
        public int MovieKindId { get; set; }
        public string MovieKindName { get; set; }
        public string? Description { get; set; }
        public List<Movie> Movie { get; set; }
    }
}
