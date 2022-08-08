Console.WriteLine("Программа проверки является ли число чётным");

Console.WriteLine("Введите целое число:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

if (number%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}