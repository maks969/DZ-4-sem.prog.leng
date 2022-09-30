// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string str = Console.ReadLine()!;
var count = str.Length!;
var array = new int[count];
for (int i = 0; i < count; i++)
{
    array[i] = int.Parse(str[i].ToString());
}
int rez = array.Sum();
Console.WriteLine(rez);