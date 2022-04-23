// Напишите метод, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// как вариант можно использовать 
// int Number = Convert.ToInt32(Console.ReadLine())

int Number =  new Random().Next(10, 100);
int Max = 0;
int MaxDigit() // показывает наибольшую цифру данного числа
{
int DigitOne = Number / 10; // первая цифра
int DigitTwo = Number % 10; // вторая цифра
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max; // возврат максимального
}
MaxDigit();
Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");
Console.WriteLine();