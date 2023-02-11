﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Input number one  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b) {
    Console.WriteLine($"Number 2 is more than number 1:   max = {b}");
}
else if (a > b) {
    Console.WriteLine($"Number 1 is more than number 2:   max = {a}");
}
else {
    Console.WriteLine($"Number 2 equal to number 1:   {a} = {b}");
}
