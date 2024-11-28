using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public abstract class Fine
    {
        public Loan Loan { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal TotalFine => CalculateFine();

        protected Fine(Loan loan, decimal baseAmount)
        {
            Loan = loan;
            BaseAmount = baseAmount;
        }

        public abstract decimal CalculateFine();
    }
}
