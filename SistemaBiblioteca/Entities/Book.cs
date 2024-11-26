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
public class Book
{
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


    private static int counterBook = 1;
    public Book(string title, List<Author> author, Categorie categorie, string iSBN, Editorial editorial, int yearPublication, int stock, Image cover, int pages)
    {
        Title = title;
        Author = author;
        Categorie = categorie;
        ISBN = iSBN;
        Editorial = editorial;
        YearPublication = yearPublication;
        Stock = stock;
        BookState = State.Disponible;
        Cover = cover;
        Pages = pages;
    }


    public override string ToString()
    {
        return $"Titulo: {Title}," +
               $"Autor: {Author}," +
               $"Categoria: {Categorie}," +
               $"ISBN: {ISBN}," +
               $"Editorial";
    }
}