int numOfLines = int.Parse(Console.ReadLine());

 
    int counter = 0;


for (int i = 1; i <= numOfLines; i++)
{
    int numOneWhole = 0;
    int numTwoWhole = 0;
    int numOneSum = 0;
    int numTwoSum = 0;
    string input = Console.ReadLine();
    string sequenceOne = "";
    string sequenceTwo = "";

    bool numOneIsDone = false;

    for (int j = 0; j < input.Length; j++)
	{
		counter++;
		char character = input[j];
		if (character == 32)
		{
			numOneIsDone = true;		
			for (int k = counter; k < input.Length; k++)
			{
                int charValue2 = int.Parse(input[k].ToString());
				numTwoSum += charValue2;
				sequenceTwo += input[k];
            }
		}
		if (numOneIsDone)
		{
			numOneWhole = int.Parse(sequenceOne);
			numTwoWhole = int.Parse(sequenceTwo);
			if (numOneWhole > numTwoWhole)
			{
				Console.WriteLine(numOneSum);
			}
			else
			{
				Console.WriteLine(numTwoSum);
			}
			break;
		}		
        int charValue = int.Parse(input[j].ToString());
        numOneSum += charValue;
        sequenceOne += input[j];
    }
}
