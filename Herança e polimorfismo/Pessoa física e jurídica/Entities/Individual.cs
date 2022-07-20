using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_física_e_jurídica.Entities
{
    class Individual : TaxPlayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
