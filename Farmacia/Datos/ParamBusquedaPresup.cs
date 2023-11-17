using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Datos
{
    public class ParamBusquedaPresup
    {
        public ParamBusquedaPresup(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }

        public string Nombre { get; set; }
        public object Valor { get; set; }


    }
}
