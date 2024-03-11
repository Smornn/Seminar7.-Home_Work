// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void GetListNatNums(int n, int m)
{
    if (m == n)
    { 
        Console.Write($"{m} ");
        return; 
    }
    Console.Write($"{m} ");
    GetListNatNums(n, m + 1);   
    
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
GetListNatNums(n, m);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Akk(n - 1, 1);
    return Akk(n - 1, Akk (n, m - 1));
}

int A = Akk(n, m);
Console.WriteLine(A);

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] mas = {1, 2, 5, 0, 10, 34};

void PrintMasVersa(int[] mas, int i = 0)
{
    if (i == 0)
    { return; }
    Console.Write($"{mas[i]} ");
    PrintMasVersa(mas, i - 1);
}

PrintMasVersa(mas, mas.Length - 1); 