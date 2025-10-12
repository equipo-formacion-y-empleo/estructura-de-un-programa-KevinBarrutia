double ConvertTemperatures(double celcius)
{
    return (celcius * 9 / 5) + 32;
}

double celsius = double.Parse(args.Length > 0 ? args[0] : "25");

Console.WriteLine($"{ConvertTemperatures(celsius):F2}°F");