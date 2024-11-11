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

        private static int counterFines = 1;
        public FineDaysLate(int daysLate, string iDFine, string iDLoan, decimal baseAmount, decimal totalFine) : base(iDFine, iDLoan, baseAmount, totalFine)
        {
            DaysLate = daysLate;
            iDFine = GenerateIdFine();
        }

        public override string GenerateIdFine()
        {
            return $"M{counterFines.ToString("D3")}";

        }

        public override void IncrementCounter()
        {
            counterFines++;
        }
    }
}
