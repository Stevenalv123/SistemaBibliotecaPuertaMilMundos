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
    public string Author{ get; set; }
    public Categorie Categorie { get; set; }
    public string ISBN { get; set; }
    public Editorial Editorial { get; set; }
    public int YearPublication { get; set; }
    public int Stock { get; set; }
    public State BookState { get; set; }
    public int Pages { get; set; }


    private static int counterBook = 1;
    public Book(string title, string author, Categorie categorie, string iSBN, Editorial editorial, int yearPublication, int stock, State state, int pages)
    {
        Title = title;
        Author = author;
        Categorie = categorie;
        ISBN = iSBN;
        Editorial = editorial;
        YearPublication = yearPublication;
        Stock = stock;
        BookState = State.Disponible;
        Pages = pages;
    }


    public override string ToString()
    {
        return $"Titulo: {Title}" +
               $"\nAutor: {Author}" +
               $"\nCategoria: {Categorie.Name}" +
               $"\nISBN: {ISBN}" +
               $"\nEditorial: {Editorial.Name}" +
               $"\nAño de publicacion: {YearPublication}" +
               $"\nStock: {Stock}" +
               $"\nEstado: {BookState}" +
               $"\nNumero de Paginas: {Pages}";
    }
}