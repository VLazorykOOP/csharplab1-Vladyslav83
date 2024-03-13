using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть номер завдання від 1 до 6:");
        string input = Console.ReadLine();
        int taskNumber;

        if (int.TryParse(input, out taskNumber) && taskNumber >= 1 && taskNumber <= 6)
        {
            switch (taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Номер завдання повинен бути від 1 до 6.");
        }
    }

    static void Task1()
    {
         Console.WriteLine("Введіть координати вершин трикутника:");
        
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Використовуємо формулу відстані між двома точками для знаходження сторін трикутника
        double side1 = DistanceBetweenPoints(x1, y1, x2, y2);
        double side2 = DistanceBetweenPoints(x2, y2, x3, y3);
        double side3 = DistanceBetweenPoints(x3, y3, x1, y1);

        // Обчислюємо периметр
        double perimeter = side1 + side2 + side3;

        Console.WriteLine($"Периметр трикутника: {perimeter}");
    }

    // Метод для обчислення відстані між двома точками
    static double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return distance;
    }
    

    static void Task2()
    {
        Console.WriteLine("Введіть двозначне число:");
        int number = int.Parse(Console.ReadLine());

        // Перевірка на двозначність числа
        if (number >= 10 && number <= 99)
        {
            // Отримання суми цифр числа
            int sumOfDigits = (number % 10) + (number / 10);

            // Перевірка на кратність трьом
            if (sumOfDigits % 3 == 0)
            {
                Console.WriteLine($"Сума цифр числа {number} кратна трьом.");
            }
            else
            {
                Console.WriteLine($"Сума цифр числа {number} не кратна трьом.");
            }
        }
        else
        {
            Console.WriteLine("Введене число не є двозначним.");
        }
    }

    static void Task3()
    {
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && x < 50 && y > 0 && y < 25)
        {
            Console.WriteLine("Так");
        }
        else if (x >= 0 && x <= 50 && y >= 0 && y <= 25)
        {
            Console.WriteLine("На межі");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }

    static void Task4()
    {
        int n = 10; // Введіть кількість днів
        int m = 20; // Введіть кількість місяців

        DateTime startDate = new DateTime(1990, 1, 1);
        DateTime currentDate = startDate.AddMonths(m).AddDays(n);

        Console.WriteLine("Поточний місяць: " + currentDate.ToString("MMMM"));
    }

    static void Task5()
    {
        // Просимо користувача ввести два цілі числа
            Console.WriteLine("Введіть перше ціле число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге ціле число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Викликаємо функцію та виводимо результат
            int result = SquareOfProduct(num1, num2);
            Console.WriteLine($"Квадрат добутку чисел {num1} і {num2} дорівнює {result}");

            Console.ReadLine();
        }

        // Функція для обчислення квадрату добутку двох цілих чисел
        static int SquareOfProduct(int x, int y)
        {
            int product = x * y;
            int squareOfProduct = product * product;
            return squareOfProduct;
        }
    

    static void Task6()
    {
        Console.Write("Введіть значення X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = (Math.Pow(x, 2) + Math.Pow(x, 2) * Math.Pow(y, 2)) / (Math.Pow(x, 2) + 1) * (x - y);

        Console.WriteLine($"Результат: {result}");
    }
}
