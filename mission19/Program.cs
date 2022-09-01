// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// 01234

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(num);

if(num>=10000 && num<100000)
{
    if (result[0] == result[4] && result[1] == result[3])
    {
        Console.WriteLine("Число - полиндромом");
    }
    else
    {
        Console.WriteLine("Число - не полиндромом");
    }}
else {
    Console.WriteLine("Вы ввели непятизначное число");}