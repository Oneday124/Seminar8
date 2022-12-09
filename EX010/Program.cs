// Задайте значения m и n. Напишите программу, которая найдет сумму натуральных чисел от m до n 

int SumOfNumbers(int m, int n)
{
    int sum = 0;
    while(m <= n)
    {
        sum += m;
        m++;
    }
    return sum;
}


int m = 4;
int n = 8;
System.Console.WriteLine($"{SumOfNumbers(m, n)} ");