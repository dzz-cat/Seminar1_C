
// задача 2
//Напишите программу, которая 
//на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Давайте сравним два числа.");
// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)    Console.WriteLine($"{a} больше, чем {b}");
// if (a < b)    Console.WriteLine($"{b} больше, чем {a}");
// if (a == b)   Console.WriteLine("Числа равны");


// Задача 4
// Напишите программу, которая 
// принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Дано задание - определить максимальное из трех чисел");
// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine($"{max} - самое большое число");

// Задача 6 
// Напишите программу, которая 
// на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Давайте определим является ли введеное число четным");
// Console.WriteLine("Введите число:");

// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0) 
// Console.WriteLine($"Число {a} четное");
// else 
// Console.WriteLine($"Число {a} не четное");

// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Давайте определим все четные числа в числовом ряду от 1 до N");
Console.WriteLine("Введите любое число больше 1");

int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)
{
    if (index % 2 == 0) Console.Write($"{index} ");
index++;
}