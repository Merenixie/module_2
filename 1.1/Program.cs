using System;
public class Person
{
    // Поля класса
    private string name;
    private int age;
    private string address;
    // Конструктор для инициализации полей при создании объекта
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }
    // Метод для установки имени
    public void SetName(string name)
    {
        this.name = name;
    }
    // Метод для получения имени
    public string GetName()
    {
        return name;
    }
    // Метод для установки возраста
    public void SetAge(int age)
    {
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Возраст должен быть положительным числом.");
        }
    }
    // Метод для получения возраста
    public int GetAge()
    {
        return age;
    }
    // Метод для установки адреса
    public void SetAddress(string address)
    {
        this.address = address;
    }
    // Метод для получения адреса
    public string GetAddress()
    {
        return address;
    }
    // Метод для вывода полной информации о человеке
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Адрес: {address}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Создание объектов класса Person
        Person person1 = new Person("Бурмунбек", 41, "Ташкент, Узбекистан");
        Person person2 = new Person("Махмуд", 75, "Душанбе, Таджикистан");
        // Вывод информации о каждом человеке
        person1.DisplayInfo();
        person2.DisplayInfo();
        // Изменение значений полей и повторный вывод
        person1.SetName("Виктор");
        person1.SetAge(52);
        person1.SetAddress("Бобруйск, Беларусь");
        person1.DisplayInfo();  // Обновленная информация
    }
}
