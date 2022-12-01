using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop_2
{
    public class Elettrodomestico : prodotto
    {
        private string condizione;
        public Elettrodomestico(string nome, string descrizione, string condizione, double prezzo, float iva) : base(nome, descrizione, prezzo, iva)
        {
            this.condizione = condizione;

        }
    }
    
}
