using System;

public class MyDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public MyDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    // Перевантаження оператора різниці між двома датами (результат у днях)
    public static int operator -(MyDate d1, MyDate d2)
    {
        // Перетворюємо дві дати у об'єкти DateTime
        DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
        DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);

        // Вираховуємо різницю в днях
        TimeSpan difference = date1 - date2;
        return Math.Abs(difference.Days); // Повертаємо кількість днів (без знака)
    }

    // Перевантаження оператора додавання до дати певної кількості днів
    public static MyDate operator +(MyDate date, int days)
    {
        // Створюємо об'єкт DateTime на основі дати
        DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);

        // Додаємо дні
        dateTime = dateTime.AddDays(days);

        // Повертаємо новий об'єкт MyDate
        return new MyDate(dateTime.Day, dateTime.Month, dateTime.Year);
    }

    // Перевантаження оператора для зручного виведення дати у вигляді рядка
    public override string ToString()
    {
        return $"{Day:D2}.{Month:D2}.{Year}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо дві дати
        MyDate date1 = new MyDate(3, 9, 2023);
        MyDate date2 = new MyDate(9, 9, 2024);

        // Обчислюємо різницю між датами (в днях)
        int difference = date2 - date1;
        Console.WriteLine($"Difference between {date1} and {date2} is {difference} days.");

        // Збільшуємо дату на 30 днів
        MyDate newDate = date1 + 30;
        Console.WriteLine($"Date after adding 30 days to {date1}: {newDate}");
    }
}

