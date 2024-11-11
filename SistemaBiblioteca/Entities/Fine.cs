using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public abstract class Fine
    {
        public string IDFine { get; set; }
        public string IDLoan { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal TotalFine { get; set; }


        private static int counterFines = 1;

        public Fine(string iDFine, string iDLoan, decimal baseAmount, decimal totalFine)
        {
            IDFine = GenerateIdFine();
            IDLoan = iDLoan;
            BaseAmount = baseAmount;
            TotalFine = totalFine;
        }
        public override string ToString()
        {
            return $"IDmulta {IDFine}, IDPrestamo {IDLoan}, MontoBase {BaseAmount},  TotalMulta {TotalFine}";
        }
        //Metodo para generar el ID de la multa(Fine)
        public abstract string GenerateIdFine();
        //{
        //    return $"M{counterFines.ToString("D3")}";

        //}

        public abstract void IncrementCounter();
        //{            
        //    counterFines++;
        //}
    }
}
