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

int[] massRow = new int [row];
void MidArifmeticRows(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int a = 0;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            a = a + mass[i, j];
        }
        massRow[i] = a;
    }
}

void PrintSumRows(int[] massRow)
{
    Console.WriteLine("Суммы строк");
    foreach (int i in massRow)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

int[] massRow2 = new int[row];
void CopyMass(int[] massRow2)
{
    for (int i = 0; i < massRow.Length; i++)
    {
        massRow2[i] = massRow[i];
    }
}

void MassRow(int[] massRow)
{
    int min = 0;
    for (int i = 0; i < massRow.Length; i++)
    {
        for (int j = i + 1; j < massRow.Length; j++)
        {
            if (massRow[j] < massRow[i])
            {
                min = massRow[j];
                massRow[j] = massRow[i];
                massRow[i] = min;
            }
        }
    }

}

int FindIndex()
{
    int a = 0;
    for (int i = 0; i < massRow2.Length; i++)
    {
        if (massRow[0] == massRow2[i])
        {
            a = i;
        }
    }
    return a;
}


int[,] mass = new int [row,colum];
FillMass(mass);
PrintMass(mass);
MidArifmeticRows(mass);
Console.WriteLine();
PrintSumRows(massRow);
CopyMass(massRow2);
MassRow(massRow);
int index = FindIndex();
Console.WriteLine();
Console.WriteLine($"Строка с индексом {index} с наименьшей суммой равна {massRow[0]}");