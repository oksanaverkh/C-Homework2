// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

// От -2 147 483 648 до 2 147 483 647 - maximum fot int type

if (number < 100 && number > -100) Console.WriteLine("There is NO 3rd number");
else
{
    if ((number < Math.Pow(10, 3) && number >= 100) || (number > -Math.Pow(10, 3) && number <= -100))
    {
        int a3 = Math.Abs(number % 10 % 10);
        Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
    }
    else
    {
        if (number < Math.Pow(10, 4) && number >= Math.Pow(10, 3) || number > -Math.Pow(10, 4) && number <= -Math.Pow(10, 3))
        {
            int a3 = Math.Abs((number / 10) % 10);
            Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
        }
        else
        {
            if (number < Math.Pow(10, 5) && number >= Math.Pow(10, 4) || number > -Math.Pow(10, 5) && number <= -Math.Pow(10, 4))
            {
                int a3 = Math.Abs((number / 100) % 10);
                Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
            }
            else
            {
                if (number < Math.Pow(10, 6) && number >= Math.Pow(10, 5) || number > -Math.Pow(10, 6) && number <= -Math.Pow(10, 5))
                {
                    int a3 = Math.Abs((number / 1000) % 10);
                    Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
                }
                else
                {
                    if (number < Math.Pow(10, 7) && number >= Math.Pow(10, 6) || number > -Math.Pow(10, 7) && number <= -Math.Pow(10, 6))
                    {
                        int a3 = Math.Abs((number / 10000) % 10);
                        Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
                    }
                    else
                    {
                        if (number < Math.Pow(10, 8) && number >= Math.Pow(10, 7) || number > -Math.Pow(10, 8) && number <= -Math.Pow(10, 7))
                        {
                            int a3 = Math.Abs((number / 100000) % 10);
                            Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
                        }
                        else
                        {
                            if (number < Math.Pow(10, 9) && number >= Math.Pow(10, 8) || number > -Math.Pow(10, 9) && number <= -Math.Pow(10, 8))
                            {
                                int a3 = Math.Abs((number / 1000000) % 10);
                                Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
                            }
                            else
                            {
                                if (number <= 2147483647 && number >= Math.Pow(10, 9) || number >= -2147483647 && number <= -Math.Pow(10, 9))
                                {
                                    int a3 = Math.Abs((number / 10000000) % 10);
                                    Console.WriteLine($"Number is {number} -> 3rd symbol is {a3}");
                                }
                                else
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

