bool IsNotNegative(int number)
{
    return number >= 0;
    //throw new NotImplementedException();
}

int number = int.Parse(args.Length > 0 ? args[0] : "0");

Console.WriteLine($"¿Es {number} no negativo? {IsNotNegative(number)}");