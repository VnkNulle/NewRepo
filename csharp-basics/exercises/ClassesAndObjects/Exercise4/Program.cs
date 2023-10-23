using System;
using System.Collections.Generic;

class Movie
{
    public string Title { get; set; }
    public string Studio { get; set; }
    public string Rating { get; set; }

    public Movie(string title, string studio, string rating)
    {
        Title = title;
        Studio = studio;
        Rating = rating;
    }

    public static Movie WithTitleAndStudio(string title, string studio)
    {
        return new Movie(title, studio, "PG");
    }

    public static List<Movie> GetPG(List<Movie> movieList)
    {
        List<Movie> pgMovies = new List<Movie>();
        foreach (Movie movie in movieList)
        {
            if (movie.Rating == "PG")
            {
                pgMovies.Add(movie);
            }
        }
        return pgMovies;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG-13");
        Movie movie2 = new Movie("Glass", "Buena Vista International", "PG-13");
        Movie movie3 = Movie.WithTitleAndStudio("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

        List<Movie> movieList = new List<Movie> { movie1, movie2, movie3 };

        List<Movie> pgMovies = Movie.GetPG(movieList);

        foreach (Movie movie in pgMovies)
        {
            Console.WriteLine($"Title: {movie.Title}, Studio: {movie.Studio}, Rating: {movie.Rating}");
        }
    }
}
