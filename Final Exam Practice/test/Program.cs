int numOfPieces = int.Parse(Console.ReadLine());
var pieces = new Dictionary<string, PieceInfo>();
for (int i = 0; i < numOfPieces; i++)
{
    string[] initialInput = Console.ReadLine().Split('|');
    string name = initialInput[0];
    string composer = initialInput[1];
    string key = initialInput[2];
    pieces.Add(name, new PieceInfo(composer, key));
}
string input;
while ((input = Console.ReadLine())!= "Stop")
{
    string[] arguments = input.Split('|');
    string command = arguments[0];
    switch (command)
    {
        case "Add":
            string piece;
            string key;
            Add(arguments, pieces);
            break;
        case "Remove":
            Remove(arguments, pieces);
            break;
        case "ChangeKey":
            ChangeKey(arguments, pieces);
            break;
    }
}
foreach (var piece in pieces)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
}

void Add(string[] strings, Dictionary<string, PieceInfo> pieceInfos)
{
    string piece = strings[1];
    string composer = strings[2];
    string key = strings[3];
    if (!pieceInfos.ContainsKey(piece))
    {
        pieceInfos.Add(piece, new PieceInfo(composer, key));
        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
    }
    else
    {
        Console.WriteLine($"{piece} is already in the collection!");
    }
}

void Remove(string[] arguments1, Dictionary<string, PieceInfo> dictionary)
{
    string s;
    s = arguments1[1];
    if (dictionary.ContainsKey(s))
    {
        dictionary.Remove(s);
        Console.WriteLine($"Successfully removed {s}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {s} does not exist in the collection.");
    }
}

void ChangeKey(string[] strings1, Dictionary<string, PieceInfo> pieces1)
{
    string piece1;
    string key1;
    piece1 = strings1[1];
    key1 = strings1[2];
    if (pieces1.ContainsKey(piece1))
    {
        pieces1[piece1].Key = key1;
        Console.WriteLine($"Changed the key of {piece1} to {key1}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {piece1} does not exist in the collection.");
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