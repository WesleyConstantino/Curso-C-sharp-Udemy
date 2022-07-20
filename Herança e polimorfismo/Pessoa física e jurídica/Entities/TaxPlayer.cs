using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_física_e_jurídica.Entities
{
    abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPlayer()
        {
        }
        public TaxPlayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
        
    }
}
