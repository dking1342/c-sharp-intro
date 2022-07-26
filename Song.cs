namespace csharp1
{
  class Song
  {
    public string name;
    public string band;
    public int duration;
    // static attribute is for the class and not a field specific for an object
    // static attributes can be called for the entire class
    public static int songCount = 0;

    public Song(string songName, string songBand, int songDuration)
    {
      name = songName;
      band = songBand;
      duration = songDuration;
      songCount++;
    }


  }
}