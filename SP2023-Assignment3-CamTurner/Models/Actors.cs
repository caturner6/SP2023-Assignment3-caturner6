using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SP2023_Assignment3_CamTurner.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        [Url]
        public string? IMDBUrl { get; set; }
        public byte[]? ActorPhoto { get; set; }
        [ForeignKey("Movies")]
        public int? MovieId { get; set; }
        public Movies? Movie { get; set; }


    }
}
