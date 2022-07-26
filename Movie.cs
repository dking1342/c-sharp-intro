namespace csharp1
{
  class Movie
  {
    public string name;
    public string director;
    private string? rating;

    public Movie(string movieName, string movieDirector, string movieRating)
    {
      name = movieName;
      director = movieDirector;
      Rating = movieRating;
    }

    // getters and setters
    public string Rating
    {
      get { return rating!; }
      set { 
        if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
        {
          rating = value;
        } 
        else 
        {
          rating = "NR";
        }
      }
    }
  }
}