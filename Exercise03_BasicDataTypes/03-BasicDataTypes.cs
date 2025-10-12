void DemoBasicDataTypes()
{
    int numInt = 15;
    double numDouble = 89000;
    float numFloat = 989389484948498;
    char varChar = 'A';
    string varString = "Hola";
    bool varBool = true;

    Console.WriteLine($"============= Basic Data Types =============");
    Console.WriteLine($"int: {numInt}");
    Console.WriteLine($"double: {numDouble}");
    Console.WriteLine($"float: {numFloat}");
    Console.WriteLine($"char: {varChar}");
    Console.WriteLine($"string: {varString}");
    Console.WriteLine($"bool: {varBool}");
    Console.WriteLine();
}

void ShowDataTypeSizes()
{
    Console.WriteLine("========= Tamaños de Tipos de Datos Básicos ========= ");
    Console.WriteLine($"bool:       {sizeof(bool)} bytes");
    Console.WriteLine($"char:       {sizeof(char)} bytes");
    Console.WriteLine($"int:        {sizeof(int)} bytes");
    Console.WriteLine($"float:      {sizeof(float)} bytes");
    Console.WriteLine($"double:     {sizeof(double)} bytes");
    Console.WriteLine($"decimal:    {sizeof(decimal)} bytes");
}

DemoBasicDataTypes();
ShowDataTypeSizes();
