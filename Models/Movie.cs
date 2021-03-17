using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCFEx1.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MId { get; set; }
        public string MName { get; set; }
        public string Starcast { get; set; }
        public string Producer { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
