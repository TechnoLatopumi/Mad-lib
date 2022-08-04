internal class Program
{
    private static void Main(string[] args)
    {
        string color, pluralNoun, name ;
        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a plural noun: ");
        pluralNoun = Console.ReadLine();

        Console.Write("Enter a name: ");
        name = Console.ReadLine();

        Console.WriteLine("Roses are "+ color);
        Console.WriteLine(pluralNoun +" are blue");
        Console.WriteLine("I love "+ name);

        Console.ReadLine();
    }
}