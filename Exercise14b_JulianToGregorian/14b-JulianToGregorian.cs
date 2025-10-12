using System;

void JulianToGregorian(double julianDay)
{
    // throw new NotImplementedException();
    // TODO: Implementar conversión y mostrar resultados:
    double J = julianDay;
    int Z = (int)Math.Floor(J);
    double F = J - Z;
    int A;

    if (Z < 2299161)
    {
        A = Z;
    }
    else
    {
        int alpha = (int)((Z - 1867216.25) / 36524.25);
        A = Z + 1 + alpha - (int)(alpha / 4.0);
    }

    int B = A + 1524;
    int C = (int)((B - 122.1) / 365.25);
    int D = (int)(365.25 * C);
    int E = (int)((B - D) / 30.6001);

    double day = B - D - Math.Floor(30.6001 * E) + F;
    int month = (E < 14) ? E - 1 : E - 13;
    int year = (month > 2) ? C - 4716 : C - 4715;

    Console.WriteLine($"Fecha juliana: {julianDay:F0}");
    Console.WriteLine($"Fecha gregoriana: {day:F0}/{month}/{year}");
}

// Obtener argumentos de línea de comandos
double julianDay = args.Length > 0 ? double.Parse(args[0]) : 2451545;

// Convertir fecha juliana a gregoriana
JulianToGregorian(julianDay);