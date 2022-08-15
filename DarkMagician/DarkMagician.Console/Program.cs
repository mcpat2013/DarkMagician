Console.WriteLine("WELCOM TO DARK WORLD! ");
Console.WriteLine("PLACE FULL OF MONSTERS, MAGIC AND... HOT ANIMATED GIRLS");
Console.WriteLine("WHAT IS YOUR NAME?");
var name = Console.ReadLine();
Console.WriteLine("SO..." + name + " WHATS YOUR CLASS? WARRIOR? ROGUE? OR MAGICIAN?");
var playerClass = Console.ReadLine();
if ( playerClass == "WARRIOR")
{
    Console.WriteLine("ERROR UNABLE TO CHOOSE THIS CLASS");
    Console.WriteLine("SOMETHINGS WRONG... CHOOSE AGAIN");
    playerClass = Console.ReadLine();
}
if (playerClass == "ROGUE")
{
    Console.WriteLine("ERROR UNABLE TO CHOOSE THIS CLASS");
    Console.WriteLine("SOMETHINGS WRONG... CHOOSE AGAIN");
    playerClass = Console.ReadLine();
}
if (playerClass == "MAGICIAN")
{
    Console.WriteLine("GOOD CHOICE FOR MAGIC WORLD I GUESS, BUT STILL WARRIOR GETS MORE LAID");
}
Console.WriteLine("CLOSE YOUR EYES AND GET READY FOR YOUR FIRT ADVENTURE");
Console.WriteLine();
Console.WriteLine("*SPAWNED IN ROSE RIVER VILLAGE IN VERDIN KINGDOME*");
Console.WriteLine("*ADDED NEW SKILL: MAGIC BOLT");
Console.WriteLine();   
Console.WriteLine("*I SEE GROUP OF VILLAGERS ON THE RIGHT, SHOP NEXT TO ME AND A GATEWAY");
Console.WriteLine("*WHAT SHOULD I DO?*");
Console.WriteLine();
Console.WriteLine("[SHOP / VILLAGERS / GATEWAY]");
var choose = Console.ReadLine();
if (choose == "SHOP")
{
    Console.WriteLine("Oh... you must be a new adventurer, for years i didn't saw any new hero... anyway, what would you like to buy?");


}
