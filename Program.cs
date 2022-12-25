// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7");
int DayNumber = int.Parse(Console.ReadLine()!);
if(DayNumber>0&&DayNumber<8)
{
    if(DayNumber==6 || DayNumber==7)
    {
       Console.WriteLine("День является выходным");
    }
    else
    {
        Console.WriteLine("День является рабочим");
    }
}
else
{
   Console.WriteLine("Ошибка: Вы ввели число, не входящее в диапазон от 1 до 7"); 
}