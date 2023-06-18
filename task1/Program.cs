// Задача 1:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();

int size = num.Length;     //  для любого положительного числа
int iStart = 0;
int iEnd = size - 1;

if (size != 5)
{
System.Console.WriteLine("Вы ввели не пятизначное число!");
}
if (iStart < iEnd)
{
    if (num[iStart] == num[iEnd])
    {
        System.Console.WriteLine($"Число: {num} палиндромом");
        iStart++;
        iEnd--;
    }
    else
    {
        System.Console.WriteLine($"Число: {num} не палиндромом");
    }
}