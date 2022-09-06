// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число - a ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите число - b ");
int b = int.Parse (Console.ReadLine());

if (a > b)
{
    Console.Write($"a = {a}; b = {b} > max = {a}; min = {b}" );
}
else
{
    Console.Write($"a = {a}; b= {b} > max = {b}; min = {a} ");
}