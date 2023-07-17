
string command;
List<Box> boxes = new List<Box>();
while ((command = Console.ReadLine())!= "end")
{
    string[] data = command.Split();

    string serialNumber = data[0];
    string itemName = data[1];
    int quantity = int.Parse(data[2]);
    decimal price = decimal.Parse(data[3]);

    Item item = new Item()
    {
        Name = itemName,
        Price = price
    };

    Box box = new Box()
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = quantity,
        PriceForABox = quantity * price
    };
    boxes.Add(box);
}


foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForABox:f2}");
}

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForABox { get; set; }
}
