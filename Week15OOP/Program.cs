List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFiles();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}


foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my fav movies {movie.Title} was realeased in {movie.Year}");
}

static string[] GetDataFromMyFiles()
{
    string filePath = @"C:\Users\Kärt Kristina\Desktop\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;
    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}
