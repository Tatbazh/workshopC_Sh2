// выводим случайное трехзначное число и удаляем вторую цифру этого числа
Console.Clear();
// [100,999] = [100, 1000)
int num = new Random().Next(100,1000);
int a1 = num / 100;
a1 = a1 * 10;

int a2 = num % 10;
int result = a1 +a2;
Console.WriteLine($"Первая и последняя цифры числа {num} -> {result}");