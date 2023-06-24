// напишите программу, которая на вход принимает число (число>10) и выдает его квадрат

// Исходное число
Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()) ;

if (number <= 10){
    Console.WriteLine("Ваше число мешьше 10");
}
else{
   int result = number * number;

Console.WriteLine($"Квадрат вашего числа = {result}"); 
}
Console.WriteLine("Конец программы");