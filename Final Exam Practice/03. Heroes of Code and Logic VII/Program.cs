int numOfHeroes = int.Parse(Console.ReadLine());
Dictionary<string, HeroStats> heroes = new Dictionary<string, HeroStats>();
for (int i = 0; i < numOfHeroes; i++)
{
    string[] heroList = Console.ReadLine().Split();
    string name = heroList[0];
    int hp = int.Parse(heroList[1]);
    int mp = int.Parse(heroList[2]);
    heroes.Add(name, new HeroStats(hp, mp));
}
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] arguments = input.Split(" - ");
    string command = arguments[0];
    switch (command)
    {
        case "CastSpell":
            string hero = arguments[1];
            int mp = int.Parse(arguments[2]);
            string spell = arguments[3];
            if (heroes[hero].Mp >= mp)
            {
                heroes[hero].Mp -= mp;
                Console.WriteLine($"{hero} has successfully cast {spell} and now has {heroes[hero].Mp} MP!");
            }
            else
            {
                Console.WriteLine($"{hero} does not have enough MP to cast {spell}!");
            }
            break;
        case "TakeDamage":
            hero = arguments[1];
            int damage = int.Parse(arguments[2]);
            string attacker = arguments[3];
            heroes[hero].Hp -= damage;
            if (heroes[hero].Hp > 0)
            {
                Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero].Hp} HP left!");
            }
            else
            {
                Console.WriteLine($"{hero} has been killed by {attacker}!");
                heroes.Remove(hero);
            }
            break;
        case "Recharge":
            hero = arguments[1];
            int amount = int.Parse(arguments[2]);
            if (heroes[hero].Mp + amount > 200)
            {
                amount = 200 - heroes[hero].Mp;
            }
            heroes[hero].Mp += amount;
            Console.WriteLine($"{hero} recharged for {amount} MP!");
            break;
        case "Heal":
            hero = arguments[1];
            amount = int.Parse(arguments[2]);
            if (heroes[hero].Hp + amount > 100)
            {
                amount = 100 - heroes[hero].Hp;
            }
            heroes[hero].Hp += amount;
            Console.WriteLine($"{hero} healed for {amount} HP!");
            break;
    }
}
foreach (var hero in heroes)
{
    Console.WriteLine($"{hero.Key} \n  HP: {hero.Value.Hp} \n  MP: {hero.Value.Mp}");
}
public class HeroStats
{
    public HeroStats(int hp, int mp)
    {
        Hp = hp;
        Mp = mp;
    }
    public int Hp { get; set; }
    public int Mp { get; set; }
}
