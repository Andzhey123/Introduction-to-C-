Console.WriteLine("Программа нахождения максимального из трех чисел");

Console.WriteLine("Введите первое число");

string? numberString = Console.ReadLine();

int nuberA = int.Parse(numberString!);

Console.WriteLine("Введите второе число");

string? numberStringA = Console.ReadLine();

int nuberB = int.Parse(numberStringA!);

Console.WriteLine("Введите третье число");

string? numberStringB = Console.ReadLine();

int nuberC = int.Parse(numberStringB!);

int Max = nuberA;

if (nuberB>Max)
{
    Max = nuberB;
}
if (nuberC>Max)
{
    Max = nuberC;
}

Console.WriteLine(Max+" большее число");