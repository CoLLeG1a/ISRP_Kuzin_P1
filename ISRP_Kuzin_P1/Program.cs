
    // Ввод размера матрицы.
    Random rnd = new Random();
    Console.WriteLine("Ввести количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Ввести количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    // Созданиен и заполнение матрицы
    double[,] matrix = new double[n, m];
    Console.WriteLine("Ввести элементы матрицы: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.NextDouble() * 10;
            Console.Write(matrix[i, j]);
            Console.Write(" ");

        }
        Console.WriteLine();
    }
    // ввод номера столбца, который будет удален.
    Console.Write("Ввсести номер столбца для удаления: ");
    int colDelet = int.Parse(Console.ReadLine()) - 1;
    double[,] newMatrix = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (j != colDelet)
            {
                newMatrix[i, j] = matrix[i, j];
            }
            else
            {
                newMatrix[i, j] = 0;
            }
        }
    }
    //Вывод новой матрицы.
    Console.WriteLine("Новая матрица: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
