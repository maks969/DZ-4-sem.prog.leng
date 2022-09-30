/* Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
        пример: 3, 5 -> 243 (3⁵) */


Console.WriteLine("Введите А (число которое возводим)");
double number = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите B (степень числа)");
double power = double.Parse(Console.ReadLine()!);


double exponent = number;

for (int i = 1; i < power; i++)
{
    exponent = exponent * number;
}
Console.WriteLine($"число A в степени B = {exponent}");
