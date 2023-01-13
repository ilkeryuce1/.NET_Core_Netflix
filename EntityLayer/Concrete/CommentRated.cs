using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CommentRated
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentDescription { get; set; }
        public int Rated { get; set; }
        public int MovieId { get; set; }
        public int AccountId { get; set; }
        public Movie Movie { get; set; }
        public Account Account { get; set; }

    }
}
