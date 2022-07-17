// See https://aka.ms/new-console-template for more information

Console.WriteLine("введите чколько чисел вывести");
int n =Convert.ToInt32(Console.ReadLine());
int f1 = 0, f2 = 1,f_sum;
Console.WriteLine("последовательность Фибоначчи:");
while(n>0)
{
    Console.WriteLine(f1);
    n--;
    f_sum = f1 + f2;
    f1 = f2;
    f2 = f_sum;
}

