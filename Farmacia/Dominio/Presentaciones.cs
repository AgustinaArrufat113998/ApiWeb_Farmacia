using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{


    public class Presentaciones 
    {
        public Presentaciones(int presentacionId, string presentacion)
        {
            PresentacionId = presentacionId;
            Presentacion = presentacion;
        }

        public int PresentacionId { get; set; }
        public string Presentacion { get; set; }
    }
}
