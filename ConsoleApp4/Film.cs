namespace ConsoleApp4
{
    internal class Film
    {
 
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

    
        public Film(string title, int releaseYear, string director, string genre, double rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Genre = genre;
            Rating = rating;
        }


        public override string ToString()
        {
            return $"{Title} ({ReleaseYear}) - Director: {Director}, Genre: {Genre}, Rating: {Rating}/10";
        }
    }
}
