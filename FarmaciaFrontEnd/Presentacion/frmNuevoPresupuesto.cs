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
    public partial class frmNuevoPresupuesto : Form
    {
        IServicios servicio = null; //Declaro Servicios
        MaestroPresupuesto oMaestroPresupuesto = null; //Declaro Maestro Presupuesto
        
        


        public frmNuevoPresupuesto()
        {
            InitializeComponent();
            servicio = new Servicios(); //Inicializo Servicios
            oMaestroPresupuesto = new MaestroPresupuesto(); //Inicializo Maestro Presupuesto
        }

        private void frmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            //Cargo fecha al formulario y al objeto oMaestroPresupuesto
            txtFecha.Text = Convert.ToString(DateTime.Today);
            oMaestroPresupuesto.FechaPresupuesto = DateTime.Today;

            //Cargo Nro de Presupuesto al nuevo formulario
            txtPresupNro.Text = servicio.ProxNroPresup("ProxNroPresupuesto").ToString();

            //Carga de combos del formulario Nuevo Presupuesto!!!!
            /*-------------------------------------------------------------------------------------------------*/

            //Cargo combo para Buscar Clientes para el nuevo formulario
            cboBuscarClientes.DataSource = servicio.ListarClientes("ListarClientes");
            cboBuscarClientes.ValueMember = "PersonaId";
            cboBuscarClientes.DisplayMember = "Nombre";
            cboBuscarClientes.SelectedIndex = -1;

            //Cargo combo para Buscar Medicamentos para el nuevo formulario
            cboMedicamentos.DataSource = servicio.ListarMedicamentos("ListarMedicamentos");
            cboMedicamentos.ValueMember = "MedicamentosId";
            cboMedicamentos.DisplayMember = "NombreMedic";
            cboMedicamentos.SelectedIndex = -1;

            //Cargo combo para Buscar Obras Sociales para el nuevo formulario
            cboObraSocial.DataSource = servicio.ListarObrasSociales("ListarObrasSociales");
            cboObraSocial.ValueMember = "ObraSocialId";
            cboObraSocial.DisplayMember = "NombreOS";
            cboObraSocial.SelectedIndex = -1;

            //Cargo combo para Buscar Medios de Pago para el nuevo formulario
            cboMedioPago.DataSource = servicio.ListarMedioPago("ListarMediosPago");
            cboMedioPago.ValueMember = "Id_medioPago";
            cboMedioPago.DisplayMember = "MedioPago";
            cboMedioPago.SelectedIndex = -1;

            //Cargo combo para Buscar Formas de Pago para el nuevo formulario
            cboFormaPago.DataSource = servicio.ListarFormaPagos("ListarFormasPago");
            cboFormaPago.ValueMember = "Id_formaPago";
            cboFormaPago.DisplayMember = "FormaPago";
            cboFormaPago.SelectedIndex = -1;

            //Cargo combo para Buscar Formas de Entrega para el nuevo formulario
            cboFormaEntrega.DataSource = servicio.ListarFormaEntregas("ListarFormasEntrega");
            cboFormaEntrega.ValueMember = "IdFormaEntrega";
            cboFormaEntrega.DisplayMember = "FormaEntrega";
            cboFormaEntrega.SelectedIndex = -1;

            //Cargo combo para Buscar Farmaceutico para el nuevo formulario
            cboFormaEntrega.DataSource = servicio.ListarFarmaceuticos("ListarFarmaceuticos");
            cboFormaEntrega.ValueMember = "farmaceuticoId";
            cboFormaEntrega.DisplayMember = "nomFarmaceutico";
            cboFormaEntrega.SelectedIndex = -1;

            /*-----------------------------------------------------------------------------------------------------*/
            //Fin de carga de combos en formulario nuevo prespuesto





        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Recupero datos de los combos para ir completando el nuevo formulario con objetos!!!

            ObrasSociales obrasSociales = (ObrasSociales)cboMedicamentos.SelectedItem;
            MedioPagos medioPagos = (MedioPagos)(cboMedioPago.SelectedItem);
            FormaPagos formaPagos = (FormaPagos)(cboFormaPago.SelectedItem);
            FormaEntregas formaEntregas = (FormaEntregas)(cboFormaEntrega.SelectedItem);
            

            //Llamo al metodo que valida y agrega datos a la Grilla

            int cantidad = (int)numericUpDownCantidad.Value;

            this.ValidarAgregarGrilla();          

        }


        //Metodo para agregar datos a grilla validados
        public bool ValidarAgregarGrilla()
        {
            bool resultado = false;

            //Recupero datos de los combos para ir completando el nuevo formulario con objetos!!!
             Medicamentos medicamentos = (Medicamentos)cboMedicamentos.SelectedItem;

            int cantidad = (int)numericUpDownCantidad.Value;
            medicamentos = new Medicamentos(medicamentos.MedicamentosId, medicamentos.NombreMedic, medicamentos.BajoReceta, medicamentos.Precio, medicamentos.Stock);
            DetallePresupuesto detPresupuesto = new DetallePresupuesto(medicamentos, cantidad);


            if (txtCliente.Text == null && txtVendedor.Text==null)

            {
                if ((cboMedicamentos.SelectedIndex.Equals(-1)) && (cboObraSocial.SelectedIndex.Equals(-1)))
                {

                    if (medicamentos.Stock >= cantidad)
                    {
                        if (medicamentos.BajoReceta && (chkBoxReceta.Checked == false))
                        {
                            MessageBox.Show("Debe presentar receta para este Medicamento!!!", "!!!Aviso!!!");
                            return resultado = false;
                        }


                        if (medicamentos.BajoReceta && chkBoxReceta.Checked || (medicamentos.BajoReceta == false && chkBoxReceta.Checked == false))
                        {

                            oMaestroPresupuesto.AgregarDetalles(detPresupuesto);
                            dgvDetallePresup.Rows.Add(medicamentos.MedicamentosId, medicamentos.NombreMedic, cantidad, medicamentos.Precio);

                            return resultado = true;
                        }

                        if ((medicamentos.BajoReceta == false) && chkBoxReceta.Checked)
                        {
                            MessageBox.Show("Este Medicamento no requiere receta!!!", "!!!Aviso!!!");
                            return resultado = false;
                        }

                    }

                    else
                    {
                        MessageBox.Show("Stock insuficiente para esa cantidad!!!", "!!!Aviso!!!");
                        return resultado = false;
                    }

                }

                else
                {
                    MessageBox.Show("Selecciones un Medicamento y/u Obra Social por favor!!!", "!!!Aviso!!!");
                    return resultado = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente y/o Vendedor por favor!!!", "!!!Aviso!!!");
                return resultado = false;
            }


            return resultado;
        }




        //Selecciono y agrego cliente a presupuestar
        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            //Recupero datos de los combos para ir completando el nuevo formulario con objetos!!!
            Clientes clientes = (Clientes)cboBuscarClientes.SelectedItem;
            Farmaceuticos farmaceuticos = (Farmaceuticos)(cboFarmaceutico.SelectedItem);

            txtCliente.Text = clientes.Nombre;
            txtAfiliadoNro.Text = clientes.NroAfiliado.ToString();
            txtVendedor.Text = farmaceuticos.NomFarmaceutico;
            
        }

        private void dgvDetallePresup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dgvDetallePresup.CurrentCell.ColumnIndex==4)
            {
                oMaestroPresupuesto.QuitarDetalles(dgvDetallePresup.CurrentRow.Index);
                dgvDetallePresup.Rows.Remove(dgvDetallePresup.CurrentRow);
                //Agregar metodo calcular total y subtotal
            }                               
            
        }
































    }
}
