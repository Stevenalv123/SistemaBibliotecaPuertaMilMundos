using SistemaBiblioteca.Entities;

public  class Loan
{ 
    public string Id_Loan { get; set; }
    public Student Id_User { get; set; }
    public Book Id_Book { get; set; }
    public DateTime Loan_Date { get; set; }
    public DateTime Return_Date { get; set; }

    public Loan(string id_Prestamo, Student id_User, Book id_Book, DateTime fechaPrestamo, DateTime fechaDevolucion)
    {
        Id_Loan = id_Prestamo;
        Id_User = id_User;
        Id_Book = id_Book;
        Loan_Date = fechaPrestamo;
        Return_Date = fechaDevolucion;
    }
}

