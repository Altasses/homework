﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if (numberA < numberB){
    Console.WriteLine($"{numberA} меньшее");
    Console.WriteLine($"{numberB} большее");
}
if (numberA > numberB){
    Console.WriteLine($"{numberA} большее");
    Console.WriteLine($"{numberB} меньшее");
}
if (numberA == numberB){
    Console.WriteLine("Числа равны");
}