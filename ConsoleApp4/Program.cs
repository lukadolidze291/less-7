namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Film film1 = new Film("The Shawshank Redemption", 1994, "Frank Darabont", "Drama", 9.3);
            Film film2 = new Film("Inception", 2010, "Christopher Nolan", "Science Fiction", 8.8);
            Film film3 = new Film("Dune", 2021, "Denis Villeneuve", "Science Fiction", 8.0);

           film1.Title = "First film:The Shawshank Redemption";
            film1.ReleaseYear = 1994;
            film1.Director = "Frank Darabont";
            film1.Genre = "Drama";
            film1.Rating = 9.3;

            film2.Title = "Second film:Inception";
            film2.ReleaseYear = 2010;
            film2.Director = "Christopher Nolan";
            film2.Genre = "Science Fiction";
            film2.Rating = 8.8;

            film3.Title = "Third film:Dune";
            film3.ReleaseYear = 2021;
            film3.Director = "Denis Villeneuve";
            film3.Genre = "Science Fiction";
            film3.Rating = 8.0;


            Console.WriteLine(film1);
            Console.WriteLine(film2);
            Console.WriteLine(film3);

        }
    }
}
