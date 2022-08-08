Console.WriteLine("Программа нахождения максимального из двух чисел");

Console.WriteLine("Введите первое число");

string? numberString = Console.ReadLine();

int nuberA = int.Parse(numberString!);

Console.WriteLine("Введите второе число");

string? numberStringA = Console.ReadLine();

int nuberB = int.Parse(numberStringA!);

if (nuberA>nuberB)
{
    Console.WriteLine(nuberA+" большее число ");
}
else
{
    Console.WriteLine(nuberB+" большее число ");
}