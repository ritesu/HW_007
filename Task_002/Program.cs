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

void CorrectRows(int[,] mass)
{
    int max = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = j + 1; k < mass.GetLength(1); k++)
            {
                if (mass[i,k] > mass[i,j])
                {
                    max = mass[i,k];
                    mass [i,k] = mass[i,j];
                    mass[i,j] = max;
                }
            }
        }
    }
}
int[,] mass = new int[row, colum];
FillMass(mass);
Console.WriteLine("До сортировки:");
PrintMass(mass);
CorrectRows(mass);
Console.WriteLine();
Console.WriteLine("После сортировки:");
PrintMass(mass);