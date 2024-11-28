using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class FineDaysLate : Fine
    {
        public int DaysLate { get; set; }

        public FineDaysLate(Loan loan, decimal baseAmount, int daysLate) : base(loan, baseAmount)
        {
            DaysLate = daysLate;
        }

        public override decimal CalculateFine()
        {
            return DaysLate * 10; 
        }
    }
}
