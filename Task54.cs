// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        int temp = matrix[i,j];
        for (int z = j+1; z < n; z++) {
            if (matrix[i,z] > temp) {
                matrix[i,j] = matrix[i,z];
                matrix[i,z] = temp;
                temp = matrix[i,j];
            }

        }
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
