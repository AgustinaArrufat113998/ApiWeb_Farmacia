using Farmacia.Datos;
using Farmacia.Dominio;
using Farmacia.Fachada.Implementacion;
using Farmacia.Fachada.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndFarmacia.Presentacion
{
    public partial class frmConsultarPresupuesto : Form
    {
        IServicios servicio = null;
        ParamBusquedaPresup parametros = null;
        List<MaestroPresupuesto> lMaestroPresupuesto = null;
        MaestroPresupuesto mPresup = null;
        List<ParamBusquedaPresup> lParam = null;



        public frmConsultarPresupuesto(List<MaestroPresupuesto> lMp)
        {
            InitializeComponent();
            servicio = new Servicios();
            parametros = null;
            lMaestroPresupuesto = lMp;
            mPresup = new MaestroPresupuesto();
            lParam = new List<ParamBusquedaPresup>();

        }




        private void frmNuevoPresupuesto_Load(object sender, EventArgs e)
        {

            foreach (MaestroPresupuesto mp in lMaestroPresupuesto)
            {
                txtPresupNro.Text = mp.NroPresupuesto.ToString();
                txtAfiliadoNro.Text = mp.Clientes.NroAfiliado.ToString();
                txtFecha.Text = mp.FechaPresupuesto.ToString();
                txtCliente.Text = mp.Clientes.Nombre;
                txtVendedor.Text = mp.Farmaceutico.NomFarmaceutico;
                txtSubTotal.Text = Convert.ToString(mp.SubTotalPresup);
                txtSubTotal.Text = Convert.ToString(mp.TotalPresupuesto);

                foreach (DetallePresupuesto det in mp.Detalles)
                {
                    dgvDetallePresup.Rows.Add(det.Medicamento.MedicamentosId, det.Medicamento.NombreMedic, det.Cantidad, det.Medicamento.Precio);
                    cboMedicamentos.SelectedIndex = det.Medicamento.MedicamentosId;
                    numericUpDownCantidad.Value = det.Cantidad;
                    chkBoxReceta.Checked = det.Medicamento.BajoReceta;
                }

                cboFormaPago.SelectedIndex = mp.FormaPago.Id_formaPago;
                cboMedioPago.SelectedIndex = mp.MedioPago.Id_medioPago;
                cboFormaEntrega.SelectedIndex = mp.FormaEntregas.IdFormaEntrega;
                cboObraSocial.SelectedIndex = mp.Clientes.ObraSocial.ObraSocialId;


            }





        }






    }
}
