string ReadNumber(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string[] GetMatrix(int rowsCount)
{
    string[] matrix = new string[rowsCount];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i] = ReadNumber("Введите строку");
    }
    return matrix;
}

void PrintMatrix(string?[] matrix)
{
    Console.WriteLine();
    Console.WriteLine("[{0}]", string.Join(", ", matrix));
}

string[] MatrixRowsLen3(string[] matrix)
{
    string[] matrix1 = new string[matrix.GetLength(0)];
    int j = 0;
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        if(matrix[i].Length <= 3)
        {
            matrix1[j] = matrix[i];
            j += 1;
        }
    }
    return matrix1.Where(x => x != null).ToArray();
}

int m = Convert.ToInt32(ReadNumber("Введите количество строк"));
string[] matr = GetMatrix(m);
PrintMatrix(matr);
string[] matr1 = MatrixRowsLen3(matr);
PrintMatrix(matr1);