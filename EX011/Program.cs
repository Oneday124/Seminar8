// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны 2 не отрицательных числа m и n

int FunctionOfAkkerman(int m, int n)
{
    if(m == 0) return n+1;
    if(m > 0 && n == 0) return FunctionOfAkkerman(m-1,1);
    else return FunctionOfAkkerman(m-1, FunctionOfAkkerman(m, n-1));
}

int m = 3;
int n = 2;

System.Console.WriteLine($"{FunctionOfAkkerman(m, n)} ");