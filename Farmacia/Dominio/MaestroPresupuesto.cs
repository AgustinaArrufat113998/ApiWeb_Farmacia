using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class MaestroPresupuesto
    {



        int nroPresupuesto = 0;
        int clienteId = 0;
        DateTime fechaPresupuesto;
        FormaPagos formaPago = null;
        FormaEntregas formaEntregas = null;
        MedioPagos medioPago = null;
        Clientes clientes = null;
        bool estadoPresupuesto = true;
        double subTotalPresup = 0;
        double totalPresupuesto = 0;
        List<DetallePresupuesto> detalles = null;



        public MaestroPresupuesto()
        {
          
           Detalles = new List<DetallePresupuesto>();
           
        }

        public MaestroPresupuesto(int nroPresupuesto, int clienteId, DateTime fechaPresupuesto, FormaPagos formaPago, double totalPresupuesto, bool estadoPresupuesto, List<DetallePresupuesto> detalles, MedioPagos medioPago, FormaEntregas formaEntregas, Clientes clientes, double subTotalPresup, Farmaceuticos farmaceutico)
        {
            NroPresupuesto = nroPresupuesto;
            ClienteId = clienteId;
            FechaPresupuesto = fechaPresupuesto;
            FormaPago = formaPago;
            TotalPresupuesto = totalPresupuesto;
            EstadoPresupuesto = estadoPresupuesto;
            Detalles = detalles;
            MedioPago = medioPago;
            FormaEntregas = formaEntregas;
            Clientes = clientes;
            SubTotalPresup = subTotalPresup;
            Farmaceutico = farmaceutico;
        }

        public int NroPresupuesto { get => nroPresupuesto; set => nroPresupuesto = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public DateTime FechaPresupuesto { get => fechaPresupuesto; set => fechaPresupuesto = value; }
        public FormaPagos FormaPago { get => formaPago; set => formaPago = value; }      
        public double TotalPresupuesto { get => totalPresupuesto; set => totalPresupuesto = value; }       
        public bool EstadoPresupuesto { get => estadoPresupuesto; set => estadoPresupuesto = value; }
        public List<DetallePresupuesto> Detalles { get => detalles; set => detalles = value; }
        public MedioPagos MedioPago { get => medioPago; set => medioPago = value; }
        public FormaEntregas FormaEntregas { get => formaEntregas; set => formaEntregas = value; }
        public Clientes Clientes { get => clientes; set => clientes = value; }
        public double SubTotalPresup { get; set; }
        public Farmaceuticos Farmaceutico { get; set; }


        public void AgregarDetalles(DetallePresupuesto detPresupuesto)
        {
            detalles.Add(detPresupuesto);
        }


        public void QuitarDetalles(int indice)
        {
            detalles.RemoveAt(indice);
        }
        public void SubTotal()
        {
           //TODO: RECORDAR HACER ESTE METODO
        }




       




    }
}
