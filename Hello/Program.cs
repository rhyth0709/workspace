// See https://aka.ms/new-console-template for more information
using Entity;
using BzLayer;

BiznezzLogic bz = new BiznezzLogic();

List<Movie> movies = bz.GetMovies();

if(movies!=null)
{
     foreach(var m in movies)
     {
        Console.WriteLine($"{m.Id} {m.Name} {m.Ratings} {m.Ryear}");
     }
}
else{
    Console.WriteLine("No Movies Present");
}

