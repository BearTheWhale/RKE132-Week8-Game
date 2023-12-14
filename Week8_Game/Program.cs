//Array

string folderPath = "C:\\Users\\Makrus\\Desktop\\Data";
string heroFile = "Gods.txt";
string villainFile = "Devils.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
//string[] heroes = { "Batman1", "Batman2", "Batman3", "BATMAN" };
//string[] villains = { "ManDuck", "ManCar", "ManMan", "ManBird", "Manbat" };
string[] weapon = { "Can of beans", "Banana", "Stick", "Stick but better" };


string hero = GetRndFromArray(heroes);
string HWeapon = GetRndFromArray(weapon);
string villain = GetRndFromArray(villains);
string VWeapon = GetRndFromArray(weapon);
int heroHP = GetCharecterHP(hero);
int heroStrikeStrenght = heroHP;
int villainHP = GetCharecterHP(villain);
int villainStrikeStrenght = villainHP;

Console.WriteLine($"{hero} ({heroHP} HP) and {HWeapon} vs {villain} ({villainHP} HP) and {VWeapon}");



while(heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - Hit(villain, villainStrikeStrenght);
    villainHP = villainHP - Hit(hero, heroStrikeStrenght);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villain {villain} HP: {villainHP}");

if(heroHP > 0)
{
    Console.WriteLine($"{hero} is the winer!");
}
else if(villainHP > 0)
{
    Console.WriteLine($"{villain} is the winner!");
}
else
{
    Console.WriteLine("Draw!");
}


static string GetRndFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string RndStringFromArray = someArray[randomIndex];
    return RndStringFromArray;
}

static int GetCharecterHP(string charecterName)
{
    if( charecterName.Length < 10 )
    {
        return 10;
    }
    else
    {
        return charecterName.Length;
    }
}

static int Hit(string charecterName, int CharHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, CharHP);
    if (strike == 0)
    {
        Console.WriteLine($"{charecterName} missed the target!");
    }
    else if (strike == CharHP - 1)
    {
        Console.WriteLine($"{charecterName} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{charecterName} hit {strike}!");
    }
    return strike;

}