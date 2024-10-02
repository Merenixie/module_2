﻿using System;
using System.Collections.Generic;
using System.Linq;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public override string ToString()
    {
        return $"Название: {Title}, Автор: {Author}, Год: {Year}";
    }
}
public class HomeLibrary
{
    private List<Book> books;
    public HomeLibrary()
    {
        books = new List<Book>();
    }
    // Добавление книги в библиотеку
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Книга '{book.Title}' добавлена в библиотеку.");
    }
    // Удаление книги из библиотеки по названию
    public void RemoveBook(string title)
    {
        var bookToRemove = books.FirstOrDefault(b => b.Title == title);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Книга '{title}' удалена из библиотеки.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Книга '{title}' не найдена.");
            Console.WriteLine();
        }
    }
    // Поиск книги по автору
    public List<Book> FindBooksByAuthor(string author)
    {
        var foundBooks = books.Where(b => b.Author == author).ToList();
        if (foundBooks.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Найдено книг автора '{author}':");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Книг автора '{author}' не найдено.");
            Console.WriteLine();
        }
        return foundBooks;
    }
    // Поиск книги по году
    public List<Book> FindBooksByYear(int year)
    {
        var foundBooks = books.Where(b => b.Year == year).ToList();
        if (foundBooks.Count > 0)
        {
            Console.WriteLine($"Найдено книг, изданных в {year} году:");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Книг, изданных в {year} году, не найдено.");
            Console.WriteLine();
        }
        return foundBooks;
    }
    // Сортировка книг по заголовку
    public void SortBooksByTitle()
    {
        books = books.OrderBy(b => b.Title).ToList();
        Console.WriteLine("Книги отсортированы по названию:");
        DisplayAllBooks();
        Console.WriteLine();
    }
    // Сортировка книг по автору
    public void SortBooksByAuthor()
    {
        books = books.OrderBy(b => b.Author).ToList();
        Console.WriteLine("Книги отсортированы по автору:");
        DisplayAllBooks();
        Console.WriteLine();
    }
    // Сортировка книг по году
    public void SortBooksByYear()
    {
        books = books.OrderBy(b => b.Year).ToList();
        Console.WriteLine("Книги отсортированы по году издания:");
        DisplayAllBooks();
        Console.WriteLine();
    }
    // Отображение всех книг в библиотеке
    public void DisplayAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Библиотека пуста.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Книги в библиотеке:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Создаем объект библиотеки
        HomeLibrary library = new HomeLibrary();
        // Добавляем книги в библиотеку
        library.AddBook(new Book("Путь к успеху", "Николай Соболев", 2016));
        library.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
        library.AddBook(new Book("Муму", "Иван Тургенев", 1854));
        // Отображаем все книги
        library.DisplayAllBooks();
        // Поиск книги по автору
        library.FindBooksByAuthor("Лев Толстой");
        // Поиск книги по году
        library.FindBooksByYear(2016);
        // Удаление книги
        library.RemoveBook("Муму");
        // Сортировка книг по заголовку
        library.SortBooksByTitle();
        // Сортировка книг по автору
        library.SortBooksByAuthor();
        // Сортировка книг по году издания
        library.SortBooksByYear();
    }
}
