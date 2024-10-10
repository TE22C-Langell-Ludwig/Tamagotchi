using System.IO.Compression;

public class Tamagotchi
{
    public string Name;
    private int hunger;
    private int boredom;
    private bool isAlive = true;
    private List<string> words = new List<string>() { "hello its me" };

    public void Feed()
    {
        hunger -= 20;
        hunger = Math.Max(hunger, 0);
    }
    public void Hi()
    {
        Console.WriteLine($"{Name} said " + words[Random.Shared.Next(1, words.Count)]);
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine ($"{Name} har learned {word}");
        ReduceBoredom();
    }
    public void tick()
    {
        isAlive=GetAlive();
        Console.Clear();
        boredom += 5;
        hunger += 5;
    }
    private void ReduceBoredom()
    {
        boredom -= 20;
        boredom = Math.Max(boredom, 0);

    }
    public void PrintStats()
    {

        Console.WriteLine($"{hunger} hunger, {boredom} boredom och livs status är {isAlive}");


    }
    public bool GetAlive()
    {
        if (hunger >= 100 || boredom >= 100)
        {
            return false;
        }
        return true;
    }
}
/* ---------------------------------------------------------------------------
Tamagotchi
− hunger: int
− boredom: int
− words: List<string>
− isAlive: bool
+ Name: string
----------------------------------------------------------------
+ Feed(): void
+ Hi(): void
+ Teach(word: string): void
+ Tick(): void
+ PrintStats(): void
+ GetAlive(): bool
− ReduceBoredom(): void
*/

