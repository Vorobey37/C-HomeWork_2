/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
while (a>-100 && a<100)
{
    Console.WriteLine($"{a} -> третьей цифры нет");
    return;
}
int b = a;
int i = 2;
while (b<-99 || b>99)
{
    b = b/10;
    i++;
}
int n = (a%Convert.ToInt32(Math.Pow(10,(i-2))))/Convert.ToInt32(Math.Pow(10,(i-3)));
if (a>0)
{Console.WriteLine($"{a} -> {n}");}
else {Console.WriteLine($"{a} -> {-n}");}

