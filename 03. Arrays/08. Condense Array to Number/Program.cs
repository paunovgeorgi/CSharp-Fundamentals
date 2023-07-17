int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < nums.Length - 1; i++)
{
	for (int j = 0; j < nums.Length - 1 - i; j++)
	{
		nums[j] = nums[j] + nums[j + 1];
	} 
}

Console.WriteLine(nums[0]);


