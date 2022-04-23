// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток

int a1 = new Random().Next(11, 101);
int a2 = new Random().Next(1, 11);
int result = 0;
int MultipleNumber() 
{
    result = a1 % a2;
    return result;
}
MultipleNumber();
Console.WriteLine();
if (result == 0) System.Console.WriteLine($"Число {a1} кратно числу {a2}");
    else
    {
    Console.WriteLine($"Число {a1} не кратно числу {a2}, остаток от деления равен {a1 % a2}");
    }
Console.WriteLine();
