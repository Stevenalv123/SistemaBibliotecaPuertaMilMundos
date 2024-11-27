using SistemaBiblioteca.Entities;

public  class Loan
{ 
    public string Loan_Code { get; set; }
    public Student Student_name { get; set; }
    public string Books { get; set; }
    public DateTime Loan_Date { get; set; }
    public DateTime Return_Date { get; set; }


    private static int currentLoanNumber = 0;
    public Loan(Student student_name, string books, DateTime loan_date, DateTime return_date)
    {
        Loan_Code = GenerateLoanCode();
        Student_name = student_name;
        Books = books;
        Loan_Date = loan_date;
        Return_Date = return_date;
    }

    public static string GenerateLoanCode()
    {
        currentLoanNumber++;
        return $"P{currentLoanNumber:D3}";
    }
}

