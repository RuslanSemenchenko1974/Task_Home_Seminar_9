// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Метод считывает число 
int ReadNamberInt()
{
    int a=0;
    bool parsNIsOk=false;
    while (!parsNIsOk)
    {
        
        parsNIsOk=int.TryParse(Console.ReadLine(), out int numberN);
        if(!parsNIsOk)
        {
            Console.WriteLine("Введено неверно, введите заново:");
        }
        else a=numberN;
    }
    return a;
}
// Метод выводит на экран числа
void ShowNumber(int n,int m)
{
    Console.Write($"{n} ");
    if (m==n)  Console.WriteLine();
    else
    {
        ShowNumber(n+1,m);
    }
}
Console.Clear();
Console.Write("Введите N :");
int n=ReadNamberInt();
Console.Write("Введите M :");
int m=ReadNamberInt();
if (n>m)
{
    int prom = m;
    m=n;
    n=prom;
}

ShowNumber(n,m);