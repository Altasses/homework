// Программа, которая принимает на вход трехзначное число и на выходе выдает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число");
int numberA = int.Parse(Console.ReadLine());

if (numberA > 99 && numberA < 1000){
    int numberB = numberA % 10;
    Console.WriteLine($"Последняя цифра числа - {numberB}");
}
else Console.WriteLine("Число неверное");