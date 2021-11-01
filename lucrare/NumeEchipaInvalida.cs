using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucrare
{
    [Serializable]
    class NumeEchipaInvalida : Exception
    {
        public NumeEchipaInvalida()
        { }

        public NumeEchipaInvalida(string nume) : base(String.Format("Nume echipa gresita"))
        { }
    }
}
