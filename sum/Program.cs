Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(numN).Length;
    int coffe = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        coffe = numN - numN % 10;
        result = result + (numN - coffe);
        numN = numN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numN);
Console.WriteLine("Сумма цифр в числе N : " + sumNumber);