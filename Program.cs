//nullable disable
Console.Clear();

Random rnd = new Random();
bool loop = true;
while (loop)
{
    Console.WriteLine("1. Roll die once");
    Console.WriteLine("2. Roll die 5 times");
    Console.WriteLine("3. Roll die 'n' times");
    Console.WriteLine("4. Roll die until snake eyes");
    Console.WriteLine("5. Exit");
    string option = Console.ReadLine();

    int dice1 = rnd.Next(1, 7);
    int dice2 = rnd.Next(1, 7);

    if (option == "1")
    {
        int dice1 = rnd.Next(1, 7);
        int dice2 = rnd.Next(1, 7);
        Console.Write($"{dice1},");
        Console.WriteLine($" {dice2}");
    }
    else if (option == "2")
    {
        for (int n = 0; n < 5; n++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            Console.Write($"{dice1},");
            Console.WriteLine($" {dice2}");
        }
    }
    else if (option == "3")
    {
        Console.WriteLine("Type an integer:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int n = 0; n < num; n++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            Console.Write($"{dice1},");
            Console.WriteLine($" {dice2}");
        }
    }
    else if (option == "4")
    {
        bool loop2 = false;
        while (loop2 == false)
        {
            Console.Write($"{dice1},");
            Console.WriteLine($" {dice2}");
        }
    }
    else if (option == "5")
    {
        Console.Clear();
        Console.WriteLine("Goodbye!");
        break;
    }
}