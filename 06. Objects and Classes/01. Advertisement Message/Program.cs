
using Microsoft.VisualBasic;
using System;

string[] phrases = 
{ "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
string[] events =
{
    "Now I feel good.", "I have succeeded with this product.",
    "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
    "Try it yourself, I am very satisfied.", "I feel great!"
};
string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
    Random rndm = new Random();


string randomPhrase = phrases[rndm.Next(phrases.Length)];
string randomEvent = events[rndm.Next(events.Length)];
string randomAuthor = authors[rndm.Next(authors.Length)];
string randomCity = cities[rndm.Next(cities.Length)];

Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}.");



//Console.WriteLine($"{RandomPhrase(phrases, rndm)} {RandomEvents(events, rndm)} {RandomAuthors(authors, rndm)} - {RandomCities(cities, rndm)}.");
//static string RandomPhrase(string[] strings, Random random)
//{
//    int index = random.Next(0, strings.Length);
//    return strings[index];
//}
//static string RandomEvents(string[] strings, Random random)
//{
//        int index = random.Next(0, strings.Length);
//        return strings[index];
//}
//static string RandomAuthors(string[] strings, Random random)
//{
//        int index = random.Next(0, strings.Length);
//        return strings[index];

//}
//static string RandomCities(string[] strings, Random random)
//{
//    int index = random.Next(0, strings.Length);
//    return strings[index];
//}

