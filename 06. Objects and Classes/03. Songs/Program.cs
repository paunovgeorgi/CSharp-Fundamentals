using System.Dynamic;

//int numOfSongs = int.Parse(Console.ReadLine());
//List<Song> songs = new List<Song>();

//for (int i = 0; i < numOfSongs; i++)
//{
//string[] input = Console.ReadLine().Split('_');

//Song currentSong = new Song()
//{
//    TypeList = input[0],
//    Name = input[1],
//    Time = input[2]
//};

//songs.Add(currentSong);
//}

//string searchForTypeList = Console.ReadLine();
//if (searchForTypeList == "all")
//{
//    foreach (Song song in songs)
//    {
//        Console.WriteLine(song.Name);
//    }
//}
//else
//{
//    foreach (var song in songs)
//    {
//        if (song.TypeList == searchForTypeList)
//        {
//            Console.WriteLine(song.Name);
//        }
//    }     
//}

//public class Song
//{
//    public string TypeList { get; set; }
//    public string Name { get; set; }
//    public string Time { get; set; }
//}

int n = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();
for (int i = 0; i < n; i++)
{ 
    string[] input = Console.ReadLine().Split('_');
    Song currentSong = new Song(input[0], input[1], input[2]);
    songs.Add(currentSong);
}
string command = Console.ReadLine();
if (command == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song song in songs.Where(x => x.TypeList == command))
    {
        Console.WriteLine(song.Name);
    }
}

public class Song
{
    public Song(string typeList, string name, string duration)
    {
        TypeList = typeList;
        Name = name;
        duration = duration;
    }
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string duration { get; set; }
}