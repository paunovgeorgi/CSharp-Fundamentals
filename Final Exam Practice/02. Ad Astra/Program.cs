using System.Text.RegularExpressions;
string input = Console.ReadLine();
string pattern = @"([#|\|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
MatchCollection foodSupply = Regex.Matches(input, pattern);
uint totalCalories = 0;
foreach (Match food in foodSupply)
{
    uint calories = uint.Parse(food.Groups["calories"].Value);
    totalCalories += calories;
}
uint daysToLast = totalCalories / 2000;
Console.WriteLine($"You have food to last you for: {daysToLast} days!");
foreach (Match food in foodSupply)
{
    string itemName = food.Groups["name"].Value;
    string expirationDate = food.Groups["date"].Value;
    string calories = food.Groups["calories"].Value;
    Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
}