// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
//m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Acr(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m >0 && n==0)
    {
        return (Acr(m-1, 1));
    }
    else if(m > 0 && n > 0)
    {return Acr(m-1, Acr(m, n-1));}
    else return n+1;

}
int m = Prompt( "Ведите не отрицательное число  M => ");
int n = Prompt( "Ведите не отрицательное число  N => ");
Console.Write(Acr(m, n));