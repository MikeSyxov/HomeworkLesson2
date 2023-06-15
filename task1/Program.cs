//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа. Не использовать строки
// примеры:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    Console.Write(message);                                          // Вывод приглашения
    int number = System.Convert.ToInt32(Console.ReadLine());           // Чтение строки и преобразование в число
    return number;                                                     // Возврат целого числа
}

int numUser = ReadInt("Введите трехзначное число: ");

if (numUser < 100 || numUser > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
    return;
}
System.Console.WriteLine(numUser);
System.Console.WriteLine(numUser / 10 % 10);