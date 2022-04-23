// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да 
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


int[] num = new int[2]; // двухмерный массив, каждый элемент будет иметь значение по умолчанию - число 0
int i = 0;
string[] nums = { "первое", "воторое" };
string Result = "не является";
for (i = 0; i < 2; i++)
{
    Console.WriteLine($"Введите {nums[i]} число: ");
    string writenum = Console.ReadLine()!;
    num[i] = Convert.ToInt32(writenum);
}
if (num[0] / num[1] == num[1]) 
    Result = Result.Replace("не","");
    Console.WriteLine($"Число {num[0]} {Result} квадратом числа {num[1]}");
