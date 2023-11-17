using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class MedioPagos
    {
        public MedioPagos(int id_medioPago, string medioPago)
        {
            Id_medioPago = id_medioPago;
            MedioPago = medioPago;
        }

        public int Id_medioPago { get; set; }
        public string MedioPago { get; set; }





    }
}
