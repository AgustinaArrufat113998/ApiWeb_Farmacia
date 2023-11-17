using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class DetallePresupuesto
    {
        double subTotal = 0;
        public DetallePresupuesto(Medicamentos medicamento, int cantidad)
        {
            Medicamento = medicamento;
            Cantidad = cantidad;
        }

        public Medicamentos Medicamento{ get; set; }
        public int Cantidad { get; set; }


        public double CalcularSubTotal(double pre, int cant)
        {
            subTotal += pre * cant;
            return subTotal;
        }



    }
}
