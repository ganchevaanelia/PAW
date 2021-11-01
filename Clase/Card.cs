using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Clase
{
  public class Card
    {
        public int Id { get; set; }
        public String Nume { get; set; }
        public String NrCard { get; set; }
        public String CVV { get; set; }
        public DateTime DataExpirare { get; set; }
        public List<Plata> plati { get; set; }

        public Card()
        {

        }
        public Card(string nume, string nrCard, string cVV, DateTime dataExpirare, List<Plata> plati)
        {
            Nume = nume;
            NrCard = nrCard;
            CVV = cVV;
            DataExpirare = dataExpirare;
            this.plati = plati;
        }
    }
}
