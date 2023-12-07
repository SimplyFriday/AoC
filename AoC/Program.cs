using AoC.Day02;


while (true)
{
    Console.Clear();
    Console.Write("Enter a number to run or 'x' to exit: ");

    var input = Console.ReadLine()?.ToLower()?.Trim() ?? "x";

    if (input == "x")
    {
        return;
    }
    else
    {
        int dayToRun;
        
        if (int.TryParse(input, out dayToRun))
        {
            switch (dayToRun)
            {
                case 2:
                    new Day02Main().Run();
                    break;

                default: break;
            }
        }
    }
}