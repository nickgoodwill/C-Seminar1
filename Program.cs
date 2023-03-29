//Напишите программу, которая на вход принимает число 
//и выдаёт его квадрат (число умноженное на само себя).

//int i = 0;

//if (int.TryParse(Console.ReadLine(), out i))
//{
//Console.WriteLine(i * i);
//}
//else
//{
//Console.WriteLine("OOps");
//}

// напишите программу, которая на вход принимает два числа
// и проверяет является ли первое чисор квадратом второго

//Console.Write("Введите первое число и нажмите клавишу Enter: ");
//string firstString = Console.ReadLine();
//int a = Convert.ToInt32(firstString);
//Console.Write("Введите второе число и нажмите клавишу Enter: ");
//string secondString = Console.ReadLine();
//int b = Convert.ToInt32(secondString);

//if (a == b * b)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

// программа выдает название недели по номеру 3-среда

Console.Write("Введите число от 1 до 7 и нажмите Enter: ");
string a = Console.ReadLine();

switch (a)
{
    case "1":
        Console.WriteLine("1 - Понедельник");
        break;
    case "2":
        Console.WriteLine("2 - Вторник");
        break;
    case "3":
        Console.WriteLine("3 - Среда");
        break;
    case "4":
        Console.WriteLine("4 - Четверг");
        break;
    case "5":
        Console.WriteLine("5 - Пятница");
        break;
    case "6":
        Console.WriteLine("5 - Суббота");
        break;
    case "7":
        Console.WriteLine("7 - Воскресенье");
        break;
}