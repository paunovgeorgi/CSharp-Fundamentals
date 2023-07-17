string[] elements1 = Console.ReadLine().Split();
string[] elements2 = Console.ReadLine().Split();

for (int i = 0; i < elements2.Length; i++)
{  
    for (int j = 0; j < elements1.Length; j++)
    {
        if (elements1[j] == elements2[i])
        {
            Console.Write(elements2[i] + " ");
        }
    }
}