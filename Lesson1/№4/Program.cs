//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 1;

if(num2 > num3){
    max = num2;
}
if(num3 > num2){
    max = num3;
}
Console.WriteLine($"{max} большее число из трех!");
