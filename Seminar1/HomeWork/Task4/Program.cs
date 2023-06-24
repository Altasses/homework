// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число");
int numberA = int.Parse(Console.ReadLine());
int numberB;

for (numberB = 1;numberB <= numberA;numberB++){
    if (numberB % 2 == 0)
        Console.WriteLine(numberB + "");
    
}
