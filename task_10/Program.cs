/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());
while (a<-999 || a>-100 && a<100 || a>999)
{
    Console.WriteLine($"{a} не является трехзначным числом!");
    Console.WriteLine("Введите трехзначное число:");
    a = int.Parse(Console.ReadLine());
}
Console.WriteLine($"{a} -> {(a%100)/10}");
