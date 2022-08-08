Console.WriteLine ("Программа вывода всех чётных чисел от 1 до N");

Console.WriteLine ("Введите число:");

string? NumberString1 = Console.ReadLine ();

int number1 = int.Parse (NumberString1!);

Console.WriteLine ("Чётные числа от 1 до "+ number1 +":");

int CountNumber = 0;

while (CountNumber <= number1)
{
    CountNumber +=2;
    if (CountNumber <= number1)
    {
       Console.Write (CountNumber + " "); 
    }
}