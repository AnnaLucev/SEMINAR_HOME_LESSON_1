
// Программа на вход принимает N, на выходе показывает все целые числа в промежутки от -N до N

Console.Write("Введите число  ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs() - дает модуль числа

// Первый способ
//
// for (int i = -a; i <= a; i++)
// {
//    Console.WriteLine(i);
// }
// Второй способ
//
int i = -a;
while (i <= a) {
    Console.WriteLine(i);
    i++;
}
