using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public enum ReturnCondition
    {
        Intacto,
        Dañado,
        Regular
    }
    public  class Devolution
    {
        public string LoanCode { get; set; }
        public string Book { get; set; }
        public string Student { get; set; }
        public DateTime DevolutionDate { get; set; }
        public ReturnCondition Condition { get; set; }
        public decimal Fine { get; set; }

        public Devolution(string loanCode, string book, string student, DateTime devolutionDate, ReturnCondition condition, decimal fine)
        {
            LoanCode = loanCode;
            Book = book;
            Student = student;
            DevolutionDate = devolutionDate;
            Condition = condition;
            Fine = fine;
        }
    }
}
