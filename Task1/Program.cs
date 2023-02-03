namespace Task1;

/*Одиничні лямбда-вирази
Написати 2 одиничні лямбди для обчислення значень функції у
заданій точці x і виконати їх залежно від значення x, яке вводиться з
консолі. Результат вивести на консоль в методі main.
Функція F задається таким чином:
F(x) = x^2 +4 , x>0,
F(x)=0, x<=0*/

class Program
{
    delegate double GetResult(double x);

    static void Main(string[] args)
    {
        Console.WriteLine("Введіть x ");
        GetResult getResult = null;
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            if (x > 0)
            {
                getResult = count => Math.Pow(x, 2) + 4;
            }
            if (x <= 0)
            {
                getResult = count => 0;
            }
            Console.WriteLine("Результат: " + getResult(x));
        }
        else
        {
            Console.WriteLine("Потрiбно було ввести число");
        }
    }
}

