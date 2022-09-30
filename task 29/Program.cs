// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

Console.WriteLine("Введите число");
string str = Console.ReadLine()!;
var count = str.Length!;
var array = new int[count];
for (int i = 0; i < count; i++)
{
    array[i] = int.Parse(str[i].ToString());
    Console.Write($" {array[i]},");
}