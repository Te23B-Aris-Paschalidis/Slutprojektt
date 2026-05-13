using Slutprojekt;

class program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Namn: ");
        string namn = Console.ReadLine();
        if (namn == "") namn = "Hjälten";

        Player player = new Player(namn);
        Enemy fiende = new Goblin();

        Console.WriteLine("Välkommen " + player.Name + "!");

        while (player.IsAlive() && fiende.IsAlive())
        {
            
        } 
    }
}