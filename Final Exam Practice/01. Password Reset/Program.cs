using System.Security.Cryptography.X509Certificates;
string password = Console.ReadLine();
string input;
while ((input = Console.ReadLine())!="Done")
{
    string[] arguments = input.Split();
    string command = arguments[0];
    switch (command)
    {
        case "TakeOdd":
string newPass = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPass += password[i];
                }
            }
            password = newPass;
Console.WriteLine(password);
            break;
        case "Cut":
            int index = int.Parse(arguments[1]);
            int length = int.Parse(arguments[2]);
            password = password.Remove(index, length);
            Console.WriteLine(password);
            break;
        case "Substitute":
            string substring = arguments[1];
            string substitute = arguments[2];
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            break;
    }
}
Console.WriteLine($"Your password is: {password}");