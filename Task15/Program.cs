// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (1 <= number && number <= 7)
{
    if (number == 6 || number == 7) Console.WriteLine($"YES, number {number} is a weekend");
    else Console.WriteLine($"NO, number {number} is NOT a weekend");
}
else
{
    Console.WriteLine("ERROR!");
}

