using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class FineforDamage : Fine
    {
        public string DamageDescription { get; set; }


        private static int counterFines = 1;

        public FineforDamage(string iDFine, string iDLoan, decimal baseAmount, decimal totalFine, string damageDescription) : base(iDFine, iDLoan, baseAmount, totalFine)
        {
            DamageDescription = damageDescription;
            IDFine = GenerateIdFine();

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
