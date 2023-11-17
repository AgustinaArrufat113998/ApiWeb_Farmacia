using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
  
    public class ObrasSociales
    {
        

        public ObrasSociales(int obraSocialId, string nombreOS,double descuento)
        { 
            ObraSocialId = obraSocialId;
            NombreOS = nombreOS;
            Descuento = descuento;
            
        }

        public int ObraSocialId { get; set; }
        public string NombreOS { get; set; }
        public double Descuento { get; set; }



    }
}
