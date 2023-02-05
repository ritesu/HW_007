Console.WriteLine("Введите количество строк и столбцов");
int row = int.Parse(Console.ReadLine() ?? "0");
int colum = int.Parse(Console.ReadLine() ?? "0");

void FillMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(10);
        }
    }
}

void PrintMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] mass)
{
    int a = 0;
    int b = 0;
    b = mass.GetLength(0) - 1;
    int i = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        a = mass[i, j];
        mass[i, j] = mass[b, j];
        mass[b, j] = a;
    }
}

int[,] mass = new int[row, colum];
FillMass(mass);
PrintMass(mass);
ChangeRows(mass);
Console.WriteLine();
PrintMass(mass);