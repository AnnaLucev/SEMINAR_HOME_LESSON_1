// Программа выдает название дня недели по заданному номеру


Console.Write("Введите номер дня недели  ");
int a = Convert.ToInt32(Console.ReadLine());

// if (a == 1)  Console.WriteLine("День недели - понедельник");
// else if (a == 2)  Console.WriteLine("День недели - вторник");
// else if (a == 3)  Console.WriteLine("День недели - среда");
// else if (a == 4)  Console.WriteLine("День недели - четверг");
// else if (a == 5)  Console.WriteLine("День недели - пятница");
// else if (a == 6)  Console.WriteLine("День недели - суббота");
// else if (a == 7)  Console.WriteLine("День недели - воскресенье");
// else    Console.WriteLine("Такого дня недели не существует");

switch (a)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("День недели - понедельник");
        break;
}