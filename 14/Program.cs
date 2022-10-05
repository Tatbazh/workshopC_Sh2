// входные данные - любое число, выходные - кратно ли это число 7 и 23?
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.Write($"{number} -> да");
}
else
{
    Console.Write($"{number} -> нет");
}