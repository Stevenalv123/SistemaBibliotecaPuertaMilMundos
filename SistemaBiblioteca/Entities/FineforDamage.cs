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

        public FineforDamage(Loan loan, decimal baseAmount, string damageDescription) : base(loan, baseAmount)
        {
            DamageDescription = damageDescription;
        }

        public override decimal CalculateFine()
        {
            return 500;
        }
    }
}
