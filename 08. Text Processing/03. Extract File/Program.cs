string input = Console.ReadLine();
//int nameFirstIndex = input.LastIndexOf(@"\") + 1;
//int nameLastIndex = input.LastIndexOf('.');
//string file = input.Substring(nameFirstIndex, nameLastIndex - nameFirstIndex);
string fileName = input.Substring(input.LastIndexOf(@"\" )+ 1, input.LastIndexOf('.') - input.LastIndexOf(@"\") - 1);
string extension = input.Substring(input.LastIndexOf('.')+1);
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");