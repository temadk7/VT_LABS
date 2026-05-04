namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1 (Код проверки пишем ниже)
            Console.WriteLine("Задание 1.1:");
            Rational r1 = new Rational(3, 8);
            Console.WriteLine(r1); // ожидается: 3 / 8
            Console.WriteLine();

            // Задание 1.2 (Код проверки пишем ниже)
            Console.WriteLine("Задание 1.2:");
            Rational r2 = new Rational(4);
            Console.WriteLine(r2); // ожидается: 4
            Console.WriteLine();

            // Задание 1.3 (Код проверки пишем ниже)
            Console.WriteLine("Задание 1.3:");
            Rational r3 = new Rational();
            Console.WriteLine(r3); // ожидается: 0
            Console.WriteLine();

            // Задание 1.4 (Код проверки пишем ниже)
            Console.WriteLine("Задание 1.4:");
            int denom = 0;

            if (denom == 0)
            {
                Console.WriteLine("Ошибка: знаменатель не может быть равен 0");
            }
            else
            {
                Rational r4 = new Rational(-3, denom);
                Console.WriteLine(r4);
            }
            Console.WriteLine();

            // Задание 2.1 (Код проверки пишем ниже)
            Console.WriteLine("Задание 2.1:");
            Rational r5 = new Rational(4, 8);
            Console.WriteLine(r5); // ожидается: 1 / 2
            Console.WriteLine();

            // Задание 2.2 (Код проверки пишем ниже)
            Console.WriteLine("Задание 2.2:");
            Rational r6 = new Rational(4, -9);
            Console.WriteLine(r6); // ожидается: -4 / 9

            Rational r7 = new Rational(-2, -10);
            Console.WriteLine(r7); // ожидается: 1 / 5
            Console.WriteLine();

            // Задание 3.1 (Код проверки пишем ниже)
            Console.WriteLine("Задание 3.1:");
            Rational a = new Rational(1, 2);
            Rational b = new Rational(3, 4);

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine();

            // Задание 3.2 (Код проверки пишем ниже)
            Console.WriteLine("Задание 3.2:");
            Rational c = new Rational(2, 4); // сократится до 1/2

            Console.WriteLine($"a = {a}, c = {c}");
            Console.WriteLine($"a == c: {a == c}"); // true
            Console.WriteLine($"a != b: {a != b}"); // true
        
}
    }
}