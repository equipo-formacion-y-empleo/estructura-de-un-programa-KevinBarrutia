bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
    // throw new NotImplementedException();
}

int number = int.Parse(args.Length > 0 ? args[0] : "4");

Console.WriteLine($"¿Es {number} un número par? {IsEven(number)}");