Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("WELCOM TO DARK WORLD! ");
Console.WriteLine("PLACE FULL OF MONSTERS, MAGIC AND... HOT ANIMATED GIRLS");
Console.WriteLine();
Console.WriteLine("WHAT IS YOUR NAME?");
Console.ForegroundColor = ConsoleColor.White;
var name = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("SO..." + name + " WHATS YOUR CLASS? WARRIOR? ROGUE? OR MAGICIAN?");
Console.ForegroundColor = ConsoleColor.White;
var playerClass = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
if (playerClass == "MAGICIAN")
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    
}
else
{
    while ((playerClass == "ROGUE") || (playerClass =="WARRIOR"))
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("ERROR UNABLE TO CHOOSE THIS CLASS");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("SOMETHINGS WRONG... CHOOSE AGAIN");
        Console.ForegroundColor = ConsoleColor.White;
        playerClass = Console.ReadLine();
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("GOOD CHOICE FOR MAGIC WORLD I GUESS, BUT STILL WARRIOR GETS MORE LAID");
Console.WriteLine();
Console.WriteLine("CLOSE YOUR EYES AND GET READY FOR YOUR FIRT ADVENTURE");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("*SPAWNED IN ROSE RIVER VILLAGE IN VERDIN KINGDOME*");
Console.WriteLine("*ADDED NEW SKILL: MAGIC BOLT");
Console.WriteLine();   
Console.WriteLine("*I SEE GROUP OF VILLAGERS ON THE RIGHT, SHOP NEXT TO ME AND A GATEWAY");
Console.WriteLine("*WHAT SHOULD I DO?*");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("[SHOP / VILLAGERS / GATEWAY]");
var choose = Console.ReadLine();
if (choose == "SHOP")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Oh... you must be a new adventurer, for years i didn't saw any new hero... anyway, what would you like to buy?");


}
