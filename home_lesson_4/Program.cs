// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Input number  ");
int a = Convert.ToInt32(Console.ReadLine()); 
int i = 1;

if (a <= 1) {
    Console.WriteLine("Input number is not corrected, you should input number > 1");
}
else {
while (i<= a) {
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
i ++;
}
}
