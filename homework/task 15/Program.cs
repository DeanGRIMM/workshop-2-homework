// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
Console.WriteLine ("Введите число от 1 до 7 обозначающую день недели");
int x = Convert.ToInt32 (Console.ReadLine());
if (x == 6 || x == 7) 
{
    Console.WriteLine ("выходной");
}
else if (x > 7) Console.WriteLine ("Некорректное число");
else Console.WriteLine ("Будни");