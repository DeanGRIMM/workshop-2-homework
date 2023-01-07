// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x;
int i = 0;
while (x > 0)
{
    x = x / 10;
    i++;
}
Console.WriteLine("колличество цифр в числе " + i);
if (i < 3)
{
    Console.Write("третьей цифры в числе нет");
}
else  
{
    int count = 3;
    while (i > count)
    {
        x1 = x1 / 10;
        count++;
    }
    x1 = x1 % 10;
    Console.Write("третья цифра в числе " + x1);
}
