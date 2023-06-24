// Программа которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB){
    Console.WriteLine("Да");
}
if (numberA != numberB * numberB){
    Console.WriteLine("Нет");
}