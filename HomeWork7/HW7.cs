//Task 47
static void Main ()
{
        int m = 5; 
        int n = 3; 

        double[,] array = new double[m, n];

        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble();
            }
        }

        Console.WriteLine("Случайный двумерный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
//Task 50
static void Main()
    {
        int rows = 3;
        int columns = 4;
        int[,] array = new int[rows, columns] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        int row = 1;
        int column = 2;

        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            int value = array[row, column];
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Элемент с указанными позициями не существует.");
        }
    }
//Task 52
static void Main();

        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int[] columnSums = new int[columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                columnSums[j] += array[i, j];
            }
        }

        double[] columnAverages = new double[columns];
        for (int j = 0; j < columns; j++)
        {
            columnAverages[j] = columnSums[j] / (double)rows;
        }

        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine("Среднее арифметическое в столбце {0} равно " );
        }