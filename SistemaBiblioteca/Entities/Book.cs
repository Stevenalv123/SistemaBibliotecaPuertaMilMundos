using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum State
{
    Disponible,
    Prestado,
    Reparacion,
    Perdido
}
public class Book:IBook
{
    public string Id_Book { get; set; }
    public string Title { get; set; }
    public List<Author> Author{ get; set; }
    public Categorie Categorie { get; set; }
    public string ISBN { get; set; }
    public Editorial Editorial { get; set; }
    public int YearPublication { get; set; }
    public int Stock { get; set; }
    public State BookState { get; set; }
    public Image Cover {  get; set; }
    public int Pages { get; set; }

    public Book(string title, List<Author> author, Categorie categorie, string iSBN, Editorial editorial, int yearPublication, int stock, State bookState, Image cover, int pages)
    {
        Id_Book = GetId_Book();
        Title = title;
        Author = author;
        Categorie = categorie;
        ISBN = iSBN;
        Editorial = editorial;
        YearPublication = yearPublication;
        Stock = stock;
        BookState = bookState;
        Cover = cover;
        Pages = pages;
    }

    private int counterBook = 1;
    private string GetId_Book()
    {
        string id = $"L{counterBook.ToString("D3")}";
        IncrementCounter();
        return id;

    }

    private void IncrementCounter()
    {
        counterBook++;
    }

    public void GetBook()
    {
        throw new NotImplementedException();
    }

    public void AddBook(List<Book> books)
    {
        books.Add(this);
    }

    public void DeleteBook(List<Book> books)
    {
        books.Remove(this);
    }

    public void UpdateBook()
    {
        throw new NotImplementedException();
    }
}