// Программа принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("Введите число  ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs() - дает модуль числа

if (a / 100 == 0 || a / 100 > 9) {
    Console.WriteLine("Ввод числа не корректен / This number is not correct");
}
else {
    int result = a % 10;
    Console.WriteLine($"Последняя цифра числа  {a} является  {result}");
}
