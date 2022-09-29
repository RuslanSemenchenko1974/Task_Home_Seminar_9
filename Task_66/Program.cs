// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

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
// Метод считает сумму
int Summ(int n,int m)
{
     if (m==n) return m;
    else
    {
        return n+Summ(n+1,m);
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

 int sumN=Summ(n,m);
 Console.WriteLine($"Сумма :{sumN}");

