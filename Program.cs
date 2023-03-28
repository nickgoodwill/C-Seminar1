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

Console.Write("Введите первое число и нажмите клавишу Enter: ");
string firstString = Console.ReadLine();
int a = Convert.ToInt32(firstString);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
string secondString = Console.ReadLine();
int b = Convert.ToInt32(secondString);

if (a == b * b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}