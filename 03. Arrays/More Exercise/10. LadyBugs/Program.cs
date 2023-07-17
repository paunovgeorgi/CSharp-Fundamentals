using Microsoft.Win32.SafeHandles;

int sizeOfField = int.Parse(Console.ReadLine());

int[] ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] field = new int[sizeOfField];

for (int i = 0; i < ladyBugIndexes.Length; i++)
{
    field[ladyBugIndexes[i]] = 1;
}

Console.WriteLine(field[0]);

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] ladyBugCommands = command.Split();
    switch (ladyBugCommands[1])
    {
        case "right":
            
            break;
        case "left":

            break;
    }

}

//static void MovementsOnTheField(int index, string direction, int length)
//{
//    switch (ladyBudCommands[1])
//    {
//        case "right":
//            ladyBugIndexes[(ladyBudCommands[2] + ladyBugIndexes[ladyBudCommands[0]]) = ladyBugIndexes[ladyBudCommands[0]];
//            break;
//        case "left":

//            break;
//    }
//}
