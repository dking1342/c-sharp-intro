namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {  
          // creating a new song
          Song holiday = new Song("Holiday","Green Day", 200);
          Console.WriteLine($"song count: {Song.songCount}"); // not specific to object
          Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
          Console.WriteLine($"song count: {Song.songCount}"); // not specific to object

          // Song.songCount is made for the class itself using the static attribute

          Console.WriteLine(holiday.name);          
          Console.WriteLine(kashmir.name);          
        }

    }
}