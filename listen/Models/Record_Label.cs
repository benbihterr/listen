using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace listen.Models
{
    public class Record_Label
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Song> Songs { get; set; }
    }
}
