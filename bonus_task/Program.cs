﻿/*
Петя впервые пришел на урок физкультуры в новой школе. 
Перед началом урока ученики выстраиваются по росту, в порядке невозрастания. 
Напишите программу, которая определит на какое место в шеренге Пете нужно встать, 
чтобы не нарушить традицию, если заранее известен рост каждого ученика 
и эти данные уже расположены по невозрастанию (то есть каждое следующее число не больше предыдущего). 
Если в классе есть несколько учеников с таким же ростом, как у Пети, 
то программа должна расположить его после них.

Входные данные
Первая строка входного файла INPUT.TXT содержит 
натуральное число N (N ≤ 100) – количество учеников (не считая Петю). 
Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников 
в сантиметрах в порядке невозрастания. 
Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.

Выходные данные
В выходной файл OUTPUT.TXT выведите единственное целое число – номер Пети в шеренге учеников.*/


/*Алгоритм следующий: 
 - задаем случайное число (кол-во учеников);
 - создаем случайный массив;
 - сортируем значения массива по убыванию (шеренга невозрастания);
 - задаем ещё одно случайное число (рост Пети);
 - выводим (записываем условие задачи для случайного случая);
 - определяем позицию Пети;
 - выводим результат */

Console.Clear();
int N = new Random().Next(1, 101);
Console.WriteLine(N);
int []Ai = new int[N];
for (int i=0; i<N; i++)
{
Ai[i] = new Random().Next(1, 201);
}
//Далее пузырьковая сортировка:
for (int NN=0; NN < (N-1); NN++)
{
    for (int i=0; i<(N-1-NN); i++)
    {
        if (Ai[i]<Ai[(i+1)])
        {
            int buf = Ai[i];
            Ai[i] = Ai[(i+1)];
            Ai[(i+1)] = buf;
        }
    }
}
for (int i=0; i<N; i++)
{
    Console.Write($"{Ai[i]} ");
}

Console.WriteLine();
int X = new Random().Next(1, 201);
Console.WriteLine(X);

while (X<=Ai[(N-1)])
{
    Console.WriteLine((N+1));
}

int ii = 0;
while (Ai[ii]>=X)
{
     ii = ii+1;
}
Console.WriteLine((ii+1));

