﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Ввод данных
Console.Write("Введите трёхзначное число:   ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

// Вывод ответа на экран
Console.WriteLine("Вторая цифра этого числа:    " + stringNumber[1]);

