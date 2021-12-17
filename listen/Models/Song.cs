using listen.Data;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace listen.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Length { get; set; }
        public MusicGenre MusicGenre { get; set; }

        //Relationships
        public List<Singer_Song> Singers_Songs { get; set; }

        //Record Label
        public int Record_LabelId { get; set; }
        [ForeignKey("Record_LabelId")]
        public Record_Label Record_Label { get; set; }




    }
}
