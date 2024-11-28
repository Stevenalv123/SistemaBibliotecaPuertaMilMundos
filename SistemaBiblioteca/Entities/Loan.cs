using SistemaBiblioteca.Entities;

public enum LoanState
{
    Prestado,
    Entregado,
    Vencido
}
public class Loan
{ 
    public string Loan_Code { get; set; }
    public Student Student_name { get; set; }
    public Book Book { get; set; }
    public DateTime Loan_Date { get; set; }
    public DateTime Return_Date { get; set; }
    public string Observations { get; set; }
    public LoanState State { get; set; }
    public Fine Fine { get; set; }


    private static int currentLoanNumber = 0;
    public Loan(Student student_name, Book book, DateTime loan_date, DateTime return_date, string observations, LoanState state, Fine fine)
    {
        Loan_Code = GenerateLoanCode();
        Student_name = student_name;
        Book = book;
        Loan_Date = loan_date;
        Return_Date = return_date;
        Observations = observations;
        State = state;
        Fine = fine;
    }

    public static string GenerateLoanCode()
    {
        currentLoanNumber++;
        return $"P{currentLoanNumber:D3}";
    }
}

