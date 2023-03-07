using System.ComponentModel.DataAnnotations;

namespace SP2023_Assignment3_CamTurner.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Url]
        public string? IMDBUrl { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public byte[]? MoviePoster { get; set; }
    }
}
