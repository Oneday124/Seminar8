// Задайте значение N. Напишите программу, которая выведет все натуральные числа от N до 1. Выполнить с помощью рекурсии

void EnterNutNumbers(int number)
{
    if(number >= 1)
    {
        Console.Write($"{number} ");
        number--;
        EnterNutNumbers(number);
    }

}

int number = 15;
EnterNutNumbers(number);
