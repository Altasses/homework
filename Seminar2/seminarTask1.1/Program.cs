﻿// Напишите программу, которая принимает на вход число (>0) и выводит все числа от 1 до этого числа
Console.WriteLine("Введите первое число");
int number = int.Parse(Console.ReadLine());

int index = 1;
while (index <= number)
{
    Console.WriteLine(index);
    index = index + 1;
}

