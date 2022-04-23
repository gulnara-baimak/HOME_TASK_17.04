// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int Number = Convert.ToInt32(Console.ReadLine());
int Number1 = 7;
int Number2 = 12;
if (Number % Number1 == 0 && Number % Number2 == 0)
{
Console.WriteLine($"Число {Number} кратно числу {Number1} и числу {Number2}"); 
}
else 
{
Console.WriteLine("не кратно");
}