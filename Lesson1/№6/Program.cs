//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int even;

if (num1 % 2 == 0){
    even = num1;
    Console.WriteLine($"Число {even} четное");
}
if (num1 % 2 == 1){
    even = num1;
    Console.WriteLine($"Число {even} не четное");
}