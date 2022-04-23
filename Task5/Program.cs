// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > 1000 ? a.ToString()[2] : "третей цифры нет"); 
Console.ReadKey(true);
{
    if (a >= 100 && a <=1000)
    { 
    Console.WriteLine((a / 100) % 10);
    int b = a / 100 / 10;
    int c = b % 10;
    Console.WriteLine(c);
    Console.WriteLine($"Последней цифрой числа {a} является цифра {a % 10}");
    } 
}

