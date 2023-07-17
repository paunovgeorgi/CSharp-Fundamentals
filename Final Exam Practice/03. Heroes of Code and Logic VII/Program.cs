int n = int.Parse(Console.ReadLine());
var heroes = new Dictionary<string, HeroStats>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    double hp = double.Parse(input[1]);
    double mp = double.Parse(input[2]);
    heroes.Add(name, new HeroStats(hp, mp));
}
string commands;
while ((commands = Console.ReadLine())!= "End")
{
    string[] arguments = commands.Split(" - ");
    string command = arguments[0];
    switch (command)
    {
        case "CastSpell":
            string currentHero = arguments[1];
            double neededMp = double.Parse(arguments[2]);
            string spellName = arguments[3];
            if (heroes[currentHero].Mp >= neededMp)
            {
                heroes[currentHero].Mp -= neededMp;
                Console.WriteLine($"{currentHero} has successfully cast {spellName} and now has {heroes[currentHero].Mp} MP!");
            }
            else
            {
                Console.WriteLine($"{currentHero} does not have enough MP to cast {spellName}!");
            }
            break;
        case "TakeDamage":
            currentHero = arguments[1];
            double damage = double.Parse(arguments[2]);
            string attacker = arguments[3];
            heroes[currentHero].Hp -= damage;
            if (heroes[currentHero].Hp > 0)
            {
                Console.WriteLine($"{currentHero} was hit for {damage} HP by {attacker} and now has {heroes[currentHero].Hp} HP left!");
            }
            else
            {
                Console.WriteLine($"{currentHero} has been killed by {attacker}!");
                heroes.Remove(currentHero);
            }
            break;
        case "Recharge":
            currentHero = arguments[1];
            double amount = double.Parse(arguments[2]);
            if (heroes[currentHero].Mp + amount > 200)
            {
                amount = 200 - heroes[currentHero].Mp;
            }
            heroes[currentHero].Mp += amount;
            Console.WriteLine($"{currentHero} recharged for {amount} MP!");
            break;
        case "Heal":
            currentHero = arguments[1];
            amount = double.Parse(arguments[2]);
            if (heroes[currentHero].Hp + amount > 100)
            {
                amount = 100 - heroes[currentHero].Hp;
            }
            heroes[currentHero].Hp += amount;
            Console.WriteLine($"{currentHero} healed for {amount} HP!");
            break;
    }
}
foreach (var hero in heroes)
{
    Console.WriteLine(hero.Key);
    Console.WriteLine($"  HP: {hero.Value.Hp}");
    Console.WriteLine($"  MP: {hero.Value.Mp}");
}
public class HeroStats
{
    public HeroStats(double hp, double mp)
    {
        Hp = hp;
        Mp = mp;
    }

    public double Hp { get; set; }
    public double Mp { get; set; }
}