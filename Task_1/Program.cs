//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное число");
int number = Convert.ToInt32 (Console.ReadLine());
if ((number > 99999) || (number < 10000))
{
    Console.WriteLine ("Это не пятизначное число");
}
else if ((number < 100000)&&(number > 9999))
{
   int result1 = number / 10000;
   int result2 = number % 10;
   if (result1 == result2)
   {
    Console.WriteLine ("Число является палиндромом");
   }
   else
   {
    Console.WriteLine ("Число не является палиндромом");
   }
}
