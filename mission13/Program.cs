// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
char[] array = num.ToArray();
int LenghtArray = array.Length;

if (LenghtArray>2)
{
    Console.WriteLine(array[2]);
}
else {
    Console.WriteLine("Третьей цифры нет.");
}
