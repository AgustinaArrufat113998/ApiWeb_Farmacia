using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class FormaEntregas
    {
        public FormaEntregas(int idFormaEntrega, string formaEntrega)
        {
            IdFormaEntrega = idFormaEntrega;
            FormaEntrega = formaEntrega;
        }

        public int IdFormaEntrega { get; set; }
        public string FormaEntrega { get; set; }


    }
}
