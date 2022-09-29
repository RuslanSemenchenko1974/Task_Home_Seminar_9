//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

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
        else if (numberN<0)
        {
            Console.WriteLine("Введено неверно, введите заново:");
            parsNIsOk=false;
        }
            else    a=numberN;
    }
    return a;
}

double Inkerman(double m,double n)
{
    
    if (m==0) return n+1;
    if (n==0) return Inkerman(m-1,1);
    else
    {
        return Inkerman(m-1,Inkerman(m,n-1));
    }
}
Console.Clear();
Console.Write("Введите n :");
int n=ReadNamberInt();
Console.Write("Введите m :");
int m=ReadNamberInt();

 double sumN=Inkerman(n,m);
 Console.WriteLine($"Число Инкермана ({n},{m}) : {sumN}");
