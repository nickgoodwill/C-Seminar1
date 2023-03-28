//Напишите программу, которая на вход принимает число 
//и выдаёт его квадрат (число умноженное на само себя).

int i = 0;

if (int.TryParse(Console.ReadLine(), out i))
{
Console.WriteLine(i * i);
}
else
{
Console.WriteLine("OOps");
}
