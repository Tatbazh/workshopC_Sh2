// входные данные - два любых числа, выходные - явл-ся ли 2-ое число кратным 1-му. 
//Если да, пишем "кратно". Если число 2 не кратно 1, 
//то выводим - "не кратно, остаток от деления - ..."
// [10, 99] == [10, 100)
Console.Clear();
int num = new Random().Next(10, 100);
Console.Write("Введи первое число:");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введи второе число:");
int number2 = int.Parse(Console.ReadLine()!);

int ost = number2 % number1;

if (ost == 0)
{
   Console.WriteLine($"{number1}, {number2} -> кратно"); 
}
else
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остаток -> {ost}");
}