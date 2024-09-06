using System;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }

    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }

    public override string ToString()
    {
        return $"Address: {Street}, {City}";
    }
}

public class House : ICloneable
{
    public string Owner { get; set; }
    public Address Address { get; set; }

    public House(string owner, Address address)
    {
        Owner = owner;
        Address = address;
    }

    // Поверхневе копіювання
    public object Clone()
    {
        return this.MemberwiseClone(); // Використання вбудованого методу поверхневого копіювання
    }

    // Глибоке копіювання
    public House DeepClone()
    {
        // Створюємо новий об'єкт House з новим об'єктом Address
        return new House(this.Owner, new Address(this.Address.Street, this.Address.City));
    }

    public override string ToString()
    {
        return $"House: Owner = {Owner}, {Address}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо початковий об'єкт House
        House originalHouse = new House("John", new Address("Baker Street", "London"));

        // Поверхнева копія
        House shallowCopy = (House)originalHouse.Clone();

        // Глибока копія
        House deepCopy = originalHouse.DeepClone();

        // Виведення інформації про об'єкти
        Console.WriteLine("Original House: " + originalHouse);
        Console.WriteLine("Shallow Copy House: " + shallowCopy);
        Console.WriteLine("Deep Copy House: " + deepCopy);

        // Змінюємо адресу у поверхневій копії
        shallowCopy.Address.Street = "Changed Street";
        shallowCopy.Owner = "Alice";

        // Змінюємо адресу у глибокій копії
        deepCopy.Address.Street = "Another Street";
        deepCopy.Owner = "Bob";

        // Перевіряємо, як зміни впливають на оригінал та копії
        Console.WriteLine("\nAfter modification:");
        Console.WriteLine("Original House: " + originalHouse);
        Console.WriteLine("Shallow Copy House: " + shallowCopy);
        Console.WriteLine("Deep Copy House: " + deepCopy);
    }
}

