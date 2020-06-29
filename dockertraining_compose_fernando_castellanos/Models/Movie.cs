using System.ComponentModel.DataAnnotations;

namespace dockertraining_compose_fernando_castellanos.Models
{
    public class Movie
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int? US_Gross { get; set; }
        public long? Worldwide_Gross { get; set; }
        public int? US_DVD_Sales { get; set; }
        public int? Production_Budget { get; set; }
        public string Release_Date { get; set; }
        public string MPAA_Rating { get; set; }
        public int? Running_Time_min { get; set; }
        public string Distributor { get; set; }
        public string Source { get; set; }
        public string Major_Genre { get; set; }
        public string Creative_Type { get; set; }
        public string Director { get; set; }
        public int? Rotten_Tomatoes_Rating { get; set; }
        public double? IMDB_Rating { get; set; }
        public int? IMDB_Votes { get; set; }
    }
}
