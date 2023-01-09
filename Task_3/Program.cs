// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num + 1;
Console.WriteLine ($"Таблица кубов чисел от 1 до {num} : ");
for (int i = 1; i < num2; i++)
{
    Console.WriteLine (i*i*i);
}