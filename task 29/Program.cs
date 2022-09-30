// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

int[] A = new int[8];

  for (int i = 0; i < 8; i++)
    {
      Console.WriteLine($"Введите число № {i+1} и нажмите 'ентер'");
      A[i] = int.Parse(Console.ReadLine()!);
    }
Console.WriteLine("[{0}]", string.Join(", ", A));