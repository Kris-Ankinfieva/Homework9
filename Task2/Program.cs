// Задайте значения M и N. Программа, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
int numM = Prompt("Введите число M");
int numN = Prompt("Введите число N");

int Prompt(string msg)
{
    Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int SumNumbers(int numberM, int numberN)
{
    int sum = numberM;
    if (numberN == numberM)
    {
        return 0;
    }
    else
    {
        numberM++;
        sum = numberM + SumNumbers(numberM, numberN);
        return sum;
    }
}
void PrintSumNumber(int valueM, int valueN)
{
    Console.Write(SumNumbers(valueM - 1, valueN));
}
PrintSumNumber(numM, numN);