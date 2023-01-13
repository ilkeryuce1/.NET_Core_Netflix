using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public DateTime MovieYear { get; set; }
        public string Episodes { get; set; }
        public int MovieKindId { get; set; }
        public string CoverPhotoLink { get; set; }     
        public string TrailerLink { get; set; }
        public MovieKind MovieKind { get; set; }
        public List<CommentRated> CommentRated { get; set; }
        //Yorumları filmin altında listeledik
    }
}
