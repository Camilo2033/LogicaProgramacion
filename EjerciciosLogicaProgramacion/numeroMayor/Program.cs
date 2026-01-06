using System.Timers;
var response = string. Empty;
do
{
    Console.Write("Ingrese Numero: ");
    var number = int.Parse(Console.ReadLine()!);
    if (number % 2 == 0)
    {
        Console.WriteLine($"El numero {number} es par");
    }
    else
    {
        Console.WriteLine($"El numero {number} es impar.");
    }
    Console.WriteLine("Desea continuar? [S/N]");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S"); 
