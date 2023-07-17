int n = int.Parse(Console.ReadLine());
var catalogue = new Dictionary<string, PieceInfo>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split('|');
    string pieceName = input[0];
    string composer = input[1];
    string key = input[2];
    catalogue.Add(pieceName, new PieceInfo(composer, key));
}
string additionalInput;
while ((additionalInput = Console.ReadLine())!= "Stop")
{
    string[] arguments = additionalInput.Split('|');
    string command = arguments[0];
    switch (command)
    {
        case "Add":
            string piece = arguments[1];
            string composer = arguments[2];
            string key = arguments[3];
            AddToCatalogue(catalogue, piece, composer, key);
            break;
        case "Remove":
            piece = arguments[1];
            RemoveFromCatalogue(catalogue, piece);
            break;
        case "ChangeKey":
            piece = arguments[1];
            key = arguments[2];
            ChangeKey(catalogue, piece, key);
            break;
    }
}
foreach (var pieceInfo in catalogue)
{
    Console.WriteLine($"{pieceInfo.Key} -> Composer: {pieceInfo.Value.Composer}, Key: {pieceInfo.Value.Key}");
}
void AddToCatalogue(Dictionary<string, PieceInfo> catalogueEntry, string s, string composer1, string key1)
{
    if (!catalogueEntry.ContainsKey(s))
    {
        catalogueEntry.Add(s, new PieceInfo(composer1, key1));
        Console.WriteLine($"{s} by {composer1} in {key1} added to the collection!");
    }
    else
    {
        Console.WriteLine($"{s} is already in the collection!");
    }
}

void RemoveFromCatalogue(Dictionary<string, PieceInfo> pieceInfos, string piece1)
{
    if (pieceInfos.ContainsKey(piece1))
    {
        pieceInfos.Remove(piece1);
        Console.WriteLine($"Successfully removed {piece1}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {piece1} does not exist in the collection.");
    }
}
void ChangeKey(Dictionary<string, PieceInfo> dictionary, string s1, string key2)
{
    if (dictionary.ContainsKey(s1))
    {
        Console.WriteLine($"Changed the key of {s1} to {key2}!");
        dictionary[s1].Key = key2;
    }
    else
    {
        Console.WriteLine($"Invalid operation! {s1} does not exist in the collection.");
    }
}
public class PieceInfo
{
    public PieceInfo(string composer, string key)
    {
        Composer = composer;
        Key = key;
    }
    public string Composer { get; set; }
    public string Key { get; set; }
}