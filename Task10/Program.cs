// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());

if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
    int a1 = Math.Abs((number / 10) % 10);
    Console.WriteLine($"Number is {number} -> 2nd symbol is {a1}");
}
else
{
    Console.WriteLine("ERROR!");
}