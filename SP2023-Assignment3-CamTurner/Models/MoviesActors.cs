using System.ComponentModel.DataAnnotations.Schema;

namespace SP2023_Assignment3_CamTurner.Models
{
    public class MoviesActors
    {
        public int MoviesActorsId { get; set; }
        [ForeignKey("Movies")]
        public int? MovieId { get; set; }
        public Movies? Movie { get; set; }
        [ForeignKey("Actors")]
        public int? ActorId { get; set; }
        public Actors? Actor { get; set; }
    }
}
