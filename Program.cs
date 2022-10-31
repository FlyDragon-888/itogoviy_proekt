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


int m = Convert.ToInt32(ReadNumber("Введите количество строк"));
string[] matr = GetMatrix(m);
PrintMatrix(matr);