// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Не использовать строки
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

int ReadInt(string message)
{
    Console.Write(message);                                          // Вывод приглашения
    int number = System.Convert.ToInt32(Console.ReadLine());           // Чтение строки и преобразование в число
    return number;                                                     // Возврат целого числа
}

int ranNum = ReadInt("Введите число: ");

int Show3pos(int ranNum)      // функ. деления 10 с показом остатка
{
    while (ranNum > 999)
    {
        ranNum /= 10;
    }
    return ranNum % 10;
}

bool Not3num(int ranNum)
{
    if (ranNum < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

if (Not3num(ranNum))
{
System.Console.WriteLine(Show3pos(ranNum));
}

