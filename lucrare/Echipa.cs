using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucrare
{
   public class Echipa : IComparable
    {
        private bool check;
        private DateTime data;
        private List<int> listaTrofee;

        public String Nume { get; set; }
        public bool AreLotDeJuniori { get; set; }
        public double Buget { get; set; }
        public DateTime DataInfiintarii { get; set; }
        public int[] TrofeeCastigate { get; set; }

        public Echipa(string nume, bool areLotDeJuniori, double buget, int[] trofeeCastigate)
        {

            try
            {
                Nume = nume;
            }
            catch (NumeEchipaInvalida e)
            {
                Console.WriteLine(e.Message);
            }
            AreLotDeJuniori = areLotDeJuniori;
            Buget = buget;
            TrofeeCastigate = trofeeCastigate;
        }

        public Echipa(string nume, bool check, DateTime data, double buget, List<int> listaTrofee)
        {
            try
            {
                Nume = nume;
            }
            catch (NumeEchipaInvalida e)
            {
                Console.WriteLine(e.Message);
            }
            this.check = check;
            this.data = data;
            Buget = buget;
            this.listaTrofee = listaTrofee;
        }

        public int CompareTo(object obj)
        {
            if (obj == null || (obj != null && !(obj is Echipa)))
            {
                throw new ArgumentException("Object should not null");
            }

            return this.Buget.CompareTo((obj as Echipa).Buget);
        }

        public static bool operator <(Echipa e1, Echipa e2)
        {
            return e1.Buget < e2.Buget;
        }

        public static bool operator >(Echipa e1, Echipa e2)
        {
            return e1.Buget > e2.Buget;
        }
    }
}
