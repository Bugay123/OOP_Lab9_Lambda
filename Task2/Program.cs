namespace Task2;

/*Одиничні лямбда-вирази в делегаті Funс
Написати лямбда-вираз обчислення суми квадратів двох цілих чисел.
Числа передати як параметр.*/

class Program
{
    static void Main(string[] args)
    {
        Func<double, double, double> sum = (n1, n2) => Math.Pow(n1, 2) + Math.Pow(n2, 2);
        Console.WriteLine("Результат " + sum(5, 10));
    }
}

