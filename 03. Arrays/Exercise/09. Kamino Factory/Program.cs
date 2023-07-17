int lengthOfSequence = int.Parse(Console.ReadLine());

string[] finalSequence = new string[lengthOfSequence];
string input = "";

int sequenceCounter = 0;
int finalCounter = 0;
int finalDna = 0;
int MinIndex = int.MaxValue;
int finalOneCount = 0;
bool isBiggest = false;

while ((input = Console.ReadLine()) != "Clone them!")
{

    sequenceCounter++;
    int maxSeq = 0;

    string[] newSeqence = input.Split('!');
    for (int i = 0; i < newSeqence.Length; i++)
    {
        int countOfOnes = 2;
        if (newSeqence[i] == "1")
        {
            int dnaCounter = 1;
            for (int j = i + 1; j < newSeqence.Length; j++)
            {
                if (newSeqence[j] == "1")
                {
                    countOfOnes++;
                }
                if (newSeqence[i] == newSeqence[j])
                {
                    dnaCounter++;
                }
                else
                {
                    break;
                }
            }
          
            if (dnaCounter >= maxSeq)
            {
                if (countOfOnes > finalOneCount)
                {
                    finalOneCount = countOfOnes;
                    isBiggest = true;
                }
                if (isBiggest)
                {
                    if (i < MinIndex)
                    {
                        MinIndex = i;
                        maxSeq = dnaCounter;
                        finalSequence = newSeqence;
                        finalCounter = sequenceCounter;
                        finalDna = finalOneCount;
                    }
                }
            }
        }
    }
}

Console.WriteLine($"Best DNA sample {finalCounter} with sum: {finalDna}.");
Console.WriteLine(string.Join(" ", finalSequence));