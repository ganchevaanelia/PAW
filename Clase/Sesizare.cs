using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Clase
{
    [Serializable]
   public class Sesizare
    {
        public int Id { get; set; }
        public CategorieSesizare Categorie { get; set; }
        public String Detalii { get; set; }
        public String NumePersoana { get; set; }
        public DateTime dataSesizare { get; set; }



        public Sesizare()
        {

        }

        public Sesizare(CategorieSesizare categorie, string detalii, string numePersoana)
        {
            Categorie = categorie;
            Detalii = detalii;
            NumePersoana = numePersoana;
            dataSesizare = DateTime.Now;
        }
    }
}
