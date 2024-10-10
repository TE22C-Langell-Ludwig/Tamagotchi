using System.Globalization;
Tamagotchi tamagotchi = new Tamagotchi()
{
    Name = ""
};

while (true)
{
    Console.WriteLine("yo this is your tamagotchi what do you want to name him ");
    tamagotchi.Name = Console.ReadLine();
    Console.WriteLine($"your tamagotchi is now called {tamagotchi.Name}");

    while (tamagotchi.GetAlive() == true)
    {
        Console.WriteLine($"\n 1. mata {tamagotchi.Name}");
        Console.WriteLine($"\n 2. lära {tamagotchi.Name} nya ord");
        Console.WriteLine($"\n 3. få reda på hur {tamagotchi.Name} mår");
        Console.WriteLine($"\n 4. prata med {tamagotchi.Name}");
        string Activity = Console.ReadLine();
        tamagotchi.tick();

        if (Activity == "4")
        {
            tamagotchi.Hi();
        }
        if (Activity == "2")
        {
            Console.WriteLine($"what word do you want to teach {tamagotchi.Name}");
            tamagotchi.Teach(Console.ReadLine());
        }
        if (Activity == "3")
        {
            tamagotchi.PrintStats();
        }
        if (Activity == "1")
        {
            tamagotchi.Feed();
        }
        
    }
    Console.Clear();
    Console.WriteLine($"{tamagotchi.Name} is dead, no refunds.");
    Console.ReadLine();
    break;


}




//Console.ReadLine();
