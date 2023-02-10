// Программа на вход принимает два числа и проверяет, является ли первое квадратом второго

Console.Write("Введите первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 *number2 == number1)
{
    Console.WriteLine("Квадрат второго числа равен первому числу   - TRUE");
}
else
{
    Console.WriteLine("Квадрат второго числа НЕ равен первому числу   -  FALSE");
}