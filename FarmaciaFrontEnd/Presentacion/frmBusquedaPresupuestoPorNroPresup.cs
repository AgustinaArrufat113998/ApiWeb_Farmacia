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
    public partial class frmBusquedaPresupuestoPorNroPresup : Form
    {

        IServicios servicio = null;
        ParamBusquedaPresup parametros = null;
        List<MaestroPresupuesto> lMaestroPresupuesto = null;
        MaestroPresupuesto mPresup = null;
        List<ParamBusquedaPresup> lParam = null;


        public frmBusquedaPresupuestoPorNroPresup()
        {
            InitializeComponent();
            servicio = new Servicios();
            parametros = null;
            lMaestroPresupuesto = new List<MaestroPresupuesto>();
            mPresup = new MaestroPresupuesto();
            lParam = new List<ParamBusquedaPresup>();
        }

        private void frmBusquedaPresupuestoPorNroPresup_Load(object sender, EventArgs e)
        {
            txtNroPresup.Focus();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.TraerPresupuesto();

            foreach (MaestroPresupuesto mp in lMaestroPresupuesto)
            {
                DgvBusquedaPresupNro.Rows.Add(mp.FechaPresupuesto, mp.FechaPresupuesto, mp.Clientes.Nombre, mp.TotalPresupuesto, mp.Farmaceutico.NomFarmaceutico);
            }


        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            lMaestroPresupuesto = this.TraerPresupuesto();

            frmConsultarPresupuesto consultarPresup = new frmConsultarPresupuesto(lMaestroPresupuesto);         
            consultarPresup.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }


        public List<MaestroPresupuesto> TraerPresupuesto()
        {
            parametros.Nombre = "nroPresup";
            parametros.Valor = txtNroPresup.Text;
            lParam.Add(parametros);


            return null;
                //lMaestroPresupuesto = (List<MaestroPresupuesto>)servicio.BuscarPresupuesto("BuscarPresupPorNumeroPresupuestoOK", lParam);
        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
