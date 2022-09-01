// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// 01234

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int length = num.Length;

if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine("Число - полиндромом");
}
else if (length < 5 || length > 5)
{
    Console.WriteLine("Вы ввели непятизначное число");
}
else
{
    Console.WriteLine("Число - не полиндромом");
}