using Characthers;
Spelare spelare = new(); 
Gubbe Mark = new ();
Gubbe William = new();
Fiende Brocolli = new();

bool gameloop = true;
Mark.hp = 300;
William.hp = 3;
William.mass = 30;
Console.WriteLine("Please write your name");
spelare.playername = Console.ReadLine();
if (spelare.playername == "")
{
    spelare.playername="player";
}

while (gameloop)
{
    Console.WriteLine($"{spelare.playername} HP:{spelare.hp} Mass:{spelare.mass} DMG:{spelare.dmg}");
    


    Console.WriteLine($"Mark HP:{Mark.hp} Mass:{Mark.mass} DMG:{Mark.dmg}");
    Console.WriteLine($"William HP:{William.hp} Mass:{William.mass} DMG:{William.dmg}");
    Console.WriteLine($"Brocolli HP:{Brocolli.hp} Mass:{Brocolli.mass} DMG:{Brocolli.dmg}");
    


    Console.ReadLine();
}
Console.ReadLine();