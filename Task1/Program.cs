// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.  14 -> нет  46 -> нет  161 -> да

int Number1 = new Random().Next(11, 101);
int Number2 = new Random().Next(1, 11);
int result = 0;
{
  result = Number1 % Number2;
}
System.Console.WriteLine();
if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}");
}
System.Console.WriteLine();

            
    