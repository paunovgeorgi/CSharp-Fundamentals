int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousetPrice = double.Parse(Console.ReadLine());
double keyboardtPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int headset = 0;
int mouse = 0;
int keyboard = 0;
int display = 0;

for (int i = 1; i <= lostGames; i++)
{
	if (i % 2 == 0)
	{
		headset++;
	}
	if (i % 3 == 0)
	{
		mouse++;
	}
	if (i % 2 == 0 && i % 3 == 0)
	{
		keyboard++;
	}
}
for (int j = 1; j <= keyboard; j++)
{
	if (j % 2 == 0)
	{
		display++;
	}
}
double totalExpences = headsetPrice * headset + mousetPrice * mouse + keyboardtPrice * keyboard + displayPrice * display;
Console.WriteLine($"Rage expenses: {totalExpences:F2} lv.");


