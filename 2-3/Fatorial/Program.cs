using System;

double Fatorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    return num * Fatorial(num - 1);
}

int num = int.Parse(Console.ReadLine());

Console.WriteLine(Fatorial(num));
