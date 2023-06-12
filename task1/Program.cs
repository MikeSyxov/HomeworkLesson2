//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
// примеры:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ranNum = new Random().Next(100, 1000);

System.Console.WriteLine(ranNum);
System.Console.WriteLine(ranNum / 10 % 10);

// System.Console.WriteLine(Max(ranNum));


// int Max(int ranNum)
// {
//     int num1 = ranNum / 10;
//     int num2 = ranNum % 10; 
//     if (num1 > num2)
//     {
//         return num1;
//     }
//     else
//     {
//         return num2;
//     }
// }
