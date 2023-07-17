string input = string.Empty;
while ((input = Console.ReadLine())!= "end")
{
    string reversedInput = string.Concat(input.Reverse());
    //Console.WriteLine($"{input} = {string.Concat(input.Reverse())}"); -> less code. 
   Console.WriteLine($"{input} = {reversedInput}");
}