// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("ВВедите  число : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите  число : ");
int num1 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (num >= num1)
{
    max = num;
}
if (num1 >= num)
{
    max = num1;
}
Console.WriteLine($"Число {max} большее");