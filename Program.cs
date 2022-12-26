/*
//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums (num - 1);
    
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumbtwNums(int num1, int num2)
{
    if (num1 > num2)
    {
      return  SumbtwNums(num1 - 1, num2) + num1;
    }

    if (num1 < num2)
    {
      return  SumbtwNums(num1 + 1, num2) + num1;
    }

    return 0;
}

Console.Write("Input number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int res = SumbtwNums(n1,n2) + n2;
Console.WriteLine(res);

/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int AkkermanFunc(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }

    if(m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }

    if(m > 0 && n > 0)
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }

    return 0;
}

Console.Write("Input number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int res = AkkermanFunc(n1,n2);
Console.WriteLine(res);
*/

