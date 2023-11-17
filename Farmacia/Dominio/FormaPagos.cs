using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class FormaPagos
    {
        public FormaPagos(int id_formaPago, string formaPago)
        {
            Id_formaPago = id_formaPago;
            FormaPago = formaPago;
        }

        public int Id_formaPago { get; set; }
        public string FormaPago { get; set; }



    }
}
