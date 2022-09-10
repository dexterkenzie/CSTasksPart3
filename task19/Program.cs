using System;

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string fullNumber = Console.ReadLine();

char[] ch = new char[fullNumber.Length];

for (int i = 0; i < fullNumber.Length; i++)
{
    ch[i] = fullNumber[i];
}

if (fullNumber.Length == 5)
{
    int num1 = fullNumber[0];
    int num2 = fullNumber[1];
    int num4 = fullNumber[3];
    int num5 = fullNumber[4];
    if (num1 == num5 && num2 == num4)
        Console.WriteLine("Число является палиндромом.");
        else
            Console.WriteLine("Это не палиндром.");
}
else
    Console.WriteLine("Вы ввели некорректное число. Нужно набрать пятизначное число. Пожалуйста, попробуйте снова.");