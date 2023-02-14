/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.WriteLine("Введите цифру:");
int a = int.Parse(Console.ReadLine());
while (a<1 || a>7)
{
    Console.WriteLine("Неправильная цифра, сколько дней в неделе?");
    Console.WriteLine("Введите цифру:");
    a = int.Parse(Console.ReadLine());
}
if (a<6)
{
    Console.WriteLine($"{a} -> нет");
}
else {Console.WriteLine($"{a} -> да");}
