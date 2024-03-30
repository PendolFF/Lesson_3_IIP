double CalculateFormula(int a, int b, int c, int d)
{
    double numinate = a * b;
    int denuminate = c + d;
    double result = numinate / denuminate;
    Console.WriteLine(result);
    return result;
}
CalculateFormula(1, 2, 3, 4);