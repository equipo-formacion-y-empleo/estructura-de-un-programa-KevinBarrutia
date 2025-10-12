using System;

void CalculateJulianDate(int day, int month, int year)
{
    // TODO: Implementar cálculo y mostrar resultados:
    // double julianDate = ...; // Cálculo de la fecha juliana
    double julianDate = ((1461 * (year + 4800 + (month - 14) / 12)) / 4
        + (367 * (month - 2 - 12 * ((month - 14) / 12))) / 12
        - (3 * ((year + 4900 + (month - 14) / 12) / 100)) / 4
        + day - 32075);
    Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
    Console.WriteLine($"Fecha juliana: {julianDate:F0}");
}

// Obtener argumentos de línea de comandos
int day = args.Length > 0 ? int.Parse(args[0]) : 1;
int month = args.Length > 1 ? int.Parse(args[1]) : 1;
int year = args.Length > 2 ? int.Parse(args[2]) : 2000;

// Calcular fecha juliana
CalculateJulianDate(day, month, year);