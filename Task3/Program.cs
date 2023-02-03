namespace Task3;

/*Одиничні лямбда-вирази в делегаті Predicate
Написати одиничний лямбда вираз з використанням делегату
Predicate де визначити чи є параметр додатним числом.*/

class Program
{
    static void Main(string[] args)
    {
        Predicate<int> plas = delegate (int x) { return x > 0; };
        Console.WriteLine("Введыть x ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            if (plas(x))
                Console.WriteLine("Число додатне");
            else
                Console.WriteLine("Чисто вiд'ємне");
        }
        else
        {
            Console.WriteLine("Треба було ввести число");
        }
    }
}

