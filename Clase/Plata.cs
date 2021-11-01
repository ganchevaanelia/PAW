using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Clase
{
   public class Plata 
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public String TipPersoana { get; set; }
        public TipPlata TaxaImpozit { get; set; }
        public String Detalii { get; set; }
        public double Suma { get; set; }


        public Plata()
        {

        }

        public Plata(string tipPersoana, TipPlata taxaImpozit, string detalii, double suma)
        {
            TipPersoana = tipPersoana;
            TaxaImpozit = taxaImpozit;
            Detalii = detalii;
            Suma = suma;
        }
    }
}
