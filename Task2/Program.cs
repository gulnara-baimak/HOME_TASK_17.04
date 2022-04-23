
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int a = new Random().Next(100, 1000);

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
if (a >= 100 && a <= 999)
{
    int b = a / 10;
    int c = b % 10;
    Console.WriteLine(c);
}
else 
{
    Console.WriteLine("Пользователь, ты банан!");
}

