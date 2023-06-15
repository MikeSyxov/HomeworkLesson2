// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    Console.Write(message);                                          // Вывод приглашения
    int number = System.Convert.ToInt32(Console.ReadLine());           // Чтение строки и преобразование в число
    return number;                                                     // Возврат целого числа
}

int danWeek = ReadInt("Введите день недели: ");

if (danWeek < 1 || danWeek > 7)
{
    Console.WriteLine("Это не день недели, повторите ввод");
    return;
}
void NeedDay(int danWeek)
{
    if (danWeek < 6) Console.WriteLine("Рабочий день");
    if (danWeek > 5) Console.WriteLine("Выходной день");
}
NeedDay(danWeek);