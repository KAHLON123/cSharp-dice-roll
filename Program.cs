#nullable disable
Console.Clear();

Random rnd = new Random();
bool loop = true;
int count = 0;
while (loop)
{
    Console.WriteLine("1. Roll die once");
    Console.WriteLine("2. Roll die 5 times");
    Console.WriteLine("3. Roll die 'n' times");
    Console.WriteLine("4. Roll die until snake eyes");
    Console.WriteLine("5. Exit");
    string option = Console.ReadLine();

    if (option == "1")
    {
        int dice1 = rnd.Next(1, 7);
        int dice2 = rnd.Next(1, 7);
        int sum = dice1 + dice2;
        Console.Write($"{dice1},");
        Console.WriteLine($" {dice2} (sum: {sum}");
    }
    else if (option == "2")
    {
        for (int n = 0; n < 5; n++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum2 = dice1 + dice2;
            Console.Write($"{dice1},");
            Console.WriteLine($" {dice2} (sum: {sum2})");
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
            int sum3 = dice1 + dice2;
            Console.Write($"{dice1},");
            Console.WriteLine($" {dice2} (sum:{sum3})");
        }
    }
    else if (option == "4")
    {
        bool loop2 = true;
        while (loop2)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            Console.Write($"{dice1},");
            Console.WriteLine($" {dice2}");
            count++;
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine($"It took {count} rolls to get to snake eyes!");
                break;
            }
        }
    }
    else if (option == "5")
    {
        Console.Clear();
        Console.WriteLine("Goodbye!");
        break;
    }
}