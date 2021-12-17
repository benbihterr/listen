using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace listen.Models
{
    public class Singer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Singer_Song> Singers_Songs { get; set; }
    }
}
