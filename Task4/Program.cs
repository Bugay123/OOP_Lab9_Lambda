namespace Task4;

/*Блокові лямбда-вирази
Написати блоковий лямбда-вираз знаходження суми парних цілих
чисел (які діляться на 2) від 2 до n. Номер числа вказується як
аргумент.*/

class Program
{
    static void Main(string[] args)
    {
        Func<int, int> func = n =>
        {
            int num = 0;
            for (int i = 2; i <= n; i += 2)
            {
                num += i;
            }
            return num;
        };
        Console.WriteLine("Сумма парних чисел 10: " + func(10));
        Console.WriteLine("Сумма парних чисел 5: " + func(5));
    }
}

