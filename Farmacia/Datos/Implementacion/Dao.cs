using Farmacia.Datos.Interfaces;
using Farmacia.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Datos.Implementacion
{
    public class Dao : IDao
    {
        
        //public bool EliminarRegistro(MaestroPresupuesto oVentas)
        //{
        //    throw new NotImplementedException();
        //}




        //public List<Clientes> ObtenerClientes(string SP)
        //{
        //    List<Clientes> lClientes = new List<Clientes>();

        //    DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(SP);

        //    foreach (DataRow row in tabla.Rows)
        //    {
        //        int barrioId = Convert.ToInt32(row.ItemArray[8]);
        //        string nombreBarrio = row.ItemArray[9].ToString();
        //        Barrios barrio = new Barrios(barrioId, nombreBarrio);


        //        int obraSocialId = Convert.ToInt32(row.ItemArray[2]);
        //        string nombreObraSocial = row.ItemArray[3].ToString();
        //        double descuento = Convert.ToDouble(row.ItemArray[7]);
        //        ObrasSociales obraSocial = new ObrasSociales(obraSocialId, nombreObraSocial, descuento);



        //        int personaId= Convert.ToInt32(row.ItemArray[0]);
        //        long dniCuil = Convert.ToInt64(row.ItemArray[4]);
        //        string nombre = row.ItemArray[5].ToString();
        //        string direccion = row.ItemArray[8].ToString();
        //        int numDireccion = Convert.ToInt32(row.ItemArray[9]);
        //        long telefono = Convert.ToInt64(row.ItemArray[8]);
        //        string email = row.ItemArray[9].ToString();
        //        Personas personas = new Personas(personaId, dniCuil, nombre, direccion, numDireccion, telefono, email, barrio);


        //        int clienteId = Convert.ToInt32(row.ItemArray[0]);
        //        int nroAfiliado = Convert.ToInt32(row.ItemArray[1]);
        //        Clientes clientes = new Clientes(clienteId, nroAfiliado, obraSocial, personas);
        //        lClientes.Add(clientes);
        //    }

        //    return lClientes;
                     
        //}



        public List<Laboratorios> ObtenerLaboratorio(string SP)
        {
            List<Laboratorios> lLaboratorios = new List<Laboratorios>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(SP);

            foreach (DataRow row in tabla.Rows)
            {

                long laboratorioId = Convert.ToInt64(row.ItemArray[0]);
                string nombreLaboratorio = row.ItemArray[1].ToString();                
                
                

                Laboratorios laboratorios = new Laboratorios(laboratorioId, nombreLaboratorio);
                lLaboratorios.Add(laboratorios);
            }
            return lLaboratorios;
        }

        public List<Medicamentos> ObtenerMedicamentos(string sP)
        {
            List<Medicamentos> lMedicamentos = new List<Medicamentos>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(sP);

            foreach (DataRow row in tabla.Rows)
            {

                int medicamentosId = Convert.ToInt32(row.ItemArray[0]);
                string nombreMedic = row.ItemArray[1].ToString();                                                                                          
                bool bajoReceta = Convert.ToBoolean(row.ItemArray[2]);
                double precio = Convert.ToDouble(row.ItemArray[3]);
                int stock = Convert.ToInt32(row.ItemArray[4]);

                Medicamentos medicamentos = new Medicamentos(medicamentosId, nombreMedic, bajoReceta,precio,stock);
                lMedicamentos.Add(medicamentos);
            }
            return lMedicamentos;
        }

        public List<ObrasSociales> ObtenerObrasSociales(string SP)
        {
            List<ObrasSociales> lObrasSociales = new List<ObrasSociales>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(SP);

            foreach (DataRow row in tabla.Rows)
            {

                int obraSocialId = Convert.ToInt32(row.ItemArray[0]);
                string nombreOs = row.ItemArray[1].ToString();
                int descuento = Convert.ToInt32(row.ItemArray[1]);

                ObrasSociales obrasSociales = new ObrasSociales(obraSocialId, nombreOs,descuento);
                lObrasSociales.Add(obrasSociales);
            }
            return lObrasSociales;
        }

        public bool RegistrarMedicamentos(MaestroPresupuesto oPresupuesto)
        {
            
                bool resultado = true;
                SqlTransaction t = null;

                try
                {

                    HelperDao.ObtenerInstancia().obtenerConexion().Open();
                    t = HelperDao.ObtenerInstancia().obtenerConexion().BeginTransaction();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = HelperDao.ObtenerInstancia().obtenerConexion();
                    comando.Transaction = t;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "SP";
                    comando.Parameters.AddWithValue("@id_cliente", oPresupuesto.ClienteId);
                    comando.Parameters.AddWithValue("@fecha", oPresupuesto.FechaPresupuesto);
                    comando.Parameters.AddWithValue("@id_formaPago", oPresupuesto.FormaPago.Id_formaPago);
                    comando.Parameters.AddWithValue("@id_formaPago", oPresupuesto.MedioPago.Id_medioPago);
                   
                    comando.Parameters.AddWithValue("@total", oPresupuesto.TotalPresupuesto);
                //comando.Parameters.AddWithValue("@total", oPresupuesto.SubTotal());

                comando.Parameters.AddWithValue("@estado", oPresupuesto.EstadoPresupuesto);
                

                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "@facturaNro";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(parametro);

                    comando.ExecuteNonQuery();

                    int facturaNro = (int)parametro.Value;
                    int detFactura = 1;

                    SqlCommand comandoDetalleFactura;

                    foreach (DetallePresupuesto detalle in oPresupuesto.Detalles)
                    {
                        comandoDetalleFactura = new SqlCommand();
                        comandoDetalleFactura.Connection = HelperDao.ObtenerInstancia().obtenerConexion();
                        comandoDetalleFactura.Transaction = t;
                        comandoDetalleFactura.CommandType = CommandType.StoredProcedure;
                        comandoDetalleFactura.CommandText = "sp";
                        comandoDetalleFactura.Parameters.AddWithValue("@facturaNro", facturaNro);
                        comandoDetalleFactura.Parameters.AddWithValue("@detFactura", detFactura);
                        comandoDetalleFactura.Parameters.AddWithValue("@id_medicamentos", detalle.Medicamento.MedicamentosId);
                        comandoDetalleFactura.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                        comandoDetalleFactura.ExecuteNonQuery();
                        detFactura++;

                    }


                    t.Commit();


                }
                catch (Exception)
                {

                    if (t != null)
                    {
                        t.Rollback();
                    }
                    resultado = false;
                }

                finally
                {
                    if (HelperDao.ObtenerInstancia().obtenerConexion() != null && HelperDao.ObtenerInstancia().obtenerConexion().State == ConnectionState.Open)
                    {
                    HelperDao.ObtenerInstancia().obtenerConexion().Close();
                    }
                }

                return resultado;

            

            
        }

        //Mapeo para obtener presupuesto por Nombre y Fechas

        public List<MaestroPresupuesto> ObtenerPresupuestoNombreFechas(string sp, ParamBusquedaPresup parametros)
        {
            

            List<ParamBusquedaPresup> lParametros = new List<ParamBusquedaPresup>();

            lParametros.Add(new ParamBusquedaPresup(parametros.Nombre, parametros.Valor));

            DataTable tabla = HelperDao.ObtenerInstancia().BuscarPresupuesto(sp, lParametros);

            //bool primero = true;


            List<MaestroPresupuesto> lMaestroPresup = new List<MaestroPresupuesto>();

            foreach (DataRow row in tabla.Rows)
            {

                //if (primero)
                //{
                    int obSocialId = Convert.ToInt32(row.ItemArray[0]);
                    string nombreOS = row.ItemArray[1].ToString();
                    double descuento = Convert.ToDouble(row.ItemArray[2]);
                    ObrasSociales oSociales = new ObrasSociales(obSocialId, nombreOS, descuento);



                    int clienteId = Convert.ToInt32(row.ItemArray[3]);
                    int personaId = Convert.ToInt32(row.ItemArray[4]);
                    string nombrePers = row.ItemArray[5].ToString();
                    int nroAfiliado = Convert.ToInt32(row.ItemArray[6]);
                    Clientes cliente = new Clientes(clienteId, personaId, nombrePers, nroAfiliado, oSociales);



                    int fPagoId = Convert.ToInt32(row.ItemArray[7]);
                    string fPago = row.ItemArray[8].ToString();
                    FormaPagos formaPago = new FormaPagos(fPagoId, fPago);



                    int fEntregaId = Convert.ToInt32(row.ItemArray[9]);
                    string fEntrega = row.ItemArray[10].ToString();
                    FormaEntregas formaEntrega = new FormaEntregas(fEntregaId, fEntrega);



                    int mPagoId = Convert.ToInt32(row.ItemArray[11]);
                    string mPago = row.ItemArray[12].ToString();
                    MedioPagos medioPago = new MedioPagos(mPagoId, mPago);



                    int farmaceuticoId = Convert.ToInt32(row.ItemArray[13]);
                    string nomFarmaceutico = row.ItemArray[14].ToString();
                    Farmaceuticos farma = new Farmaceuticos(farmaceuticoId, nomFarmaceutico);



                    int medicamentoId = Convert.ToInt32(row.ItemArray[15]);
                    string nombreMedic = row.ItemArray[16].ToString();
                    bool bajoReceta = Convert.ToBoolean(row.ItemArray[17]);
                    double precio = Convert.ToDouble(row.ItemArray[18]);
                    int stock = Convert.ToInt32(row.ItemArray[19]);
                    Medicamentos medic = new Medicamentos(medicamentoId, nombreMedic, bajoReceta, precio, stock);

                
                
                    
                    List<DetallePresupuesto> detPresup = new List<DetallePresupuesto>();
                    


                    int presupId= Convert.ToInt32(row.ItemArray[21]);
                    DateTime fechaPresup = Convert.ToDateTime(row.ItemArray[22]);
                    double subTotal= Convert.ToDouble(row.ItemArray[23]);
                    double Total = Convert.ToDouble(row.ItemArray[24]);
                    bool estadoPresup= Convert.ToBoolean(row.ItemArray[25]);
                    MaestroPresupuesto mPresupuesto = new MaestroPresupuesto(presupId, clienteId, fechaPresup, formaPago,Total, 
                    estadoPresup, detPresup, medioPago, formaEntrega, cliente, subTotal, farma);



                    lMaestroPresup.Add(mPresupuesto);

            }

            return lMaestroPresup;

        }

        public int ObtenerProxNroPresup(string sp)
        {
            return HelperDao.ObtenerInstancia().ProxNroPresup(sp);
        }

        public List<MedioPagos> ObtenerMediosPago(string sP)
        {
            List<MedioPagos> lMedioPagos = new List<MedioPagos>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(sP);

            foreach (DataRow row in tabla.Rows)
            {

                int medioPagolId = Convert.ToInt32(row.ItemArray[0]);
                string nombreMedioPago = row.ItemArray[1].ToString();
                

                MedioPagos medioPagos = new MedioPagos(medioPagolId,nombreMedioPago);
                lMedioPagos.Add(medioPagos);
            }
            return lMedioPagos;
        }

        public List<FormaPagos> ObtenerFormaPagos(string sP)
        {
            List<FormaPagos> lFormaPagos = new List<FormaPagos>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(sP);

            foreach (DataRow row in tabla.Rows)
            {

                int formaPagolId = Convert.ToInt32(row.ItemArray[0]);
                string nombreFormaPago = row.ItemArray[1].ToString();


                FormaPagos formaPagos = new FormaPagos(formaPagolId, nombreFormaPago);
                lFormaPagos.Add(formaPagos);
            }
            return lFormaPagos;
        }

        public List<FormaEntregas> ObtenerFormaEntregas(string sP)
        {
            List<FormaEntregas> lFormaEntregas = new List<FormaEntregas>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(sP);

            foreach (DataRow row in tabla.Rows)
            {

                int formaEntregalId = Convert.ToInt32(row.ItemArray[0]);
                string nombreFormaEntrega = row.ItemArray[1].ToString();


                FormaEntregas formaEntregas = new FormaEntregas(formaEntregalId, nombreFormaEntrega);
                lFormaEntregas.Add(formaEntregas);
            }
            return lFormaEntregas;
        }

        public List<Clientes> ObtenerClientes(string SP)
        {
            List<Clientes> lClientes = new List<Clientes>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(SP);

            foreach (DataRow row in tabla.Rows)
            {

                int clienteId = Convert.ToInt32(row.ItemArray[0]);
                int personaId = Convert.ToInt32(row.ItemArray[1]);
                string nombrePersona = row.ItemArray[2].ToString();
                int nroAfiliado = Convert.ToInt32(row.ItemArray[3]);
                
                Clientes clientes = new Clientes(clienteId, personaId,nombrePersona,nroAfiliado);
                lClientes.Add(clientes);
            }
            return lClientes;
        }


        public List<Farmaceuticos> ObtenerFarmaceuticos(string SP)
        {
            List<Farmaceuticos> lFarmaceuticos = new List<Farmaceuticos>();

            DataTable tabla = HelperDao.ObtenerInstancia().LlenarCombo(SP);

            foreach (DataRow row in tabla.Rows)
            {

                int clienteId = Convert.ToInt32(row.ItemArray[0]);
                string nombreCliente = row.ItemArray[1].ToString();
                int nroAfiliado = Convert.ToInt32(row.ItemArray[2]);

                Farmaceuticos farmaceuticos = new Farmaceuticos(clienteId, nombreCliente);

                lFarmaceuticos.Add(farmaceuticos);
            }
            return lFarmaceuticos;
        }


        //Mapeo para obtener presupuestos
        public List<MaestroPresupuesto> ObtenerPresupuesto(string sp,List<ParamBusquedaPresup> ListaParametros)
        {
           // List<ParamBusquedaPresup> lParametros = new List<ParamBusquedaPresup>();

            //ListaParametros.Add(new ParamBusquedaPresup(sp,ListaParametros));

            DataTable tabla = HelperDao.ObtenerInstancia().BuscarPresupuesto(sp, ListaParametros);

            //bool primero = true;


            List<MaestroPresupuesto> lMaestroPresupuesto = new List<MaestroPresupuesto>();

            foreach (DataRow row in tabla.Rows)
            {

                //if (primero)
                //{
                int obSocialId = Convert.ToInt32(row.ItemArray[0]);
                string nombreOS = row.ItemArray[1].ToString();
                double descuento = Convert.ToDouble(row.ItemArray[2]);
                ObrasSociales oSociales = new ObrasSociales(obSocialId, nombreOS, descuento);



                int clienteId = Convert.ToInt32(row.ItemArray[3]);
                int personaId = Convert.ToInt32(row.ItemArray[4]);
                string nombrePers = row.ItemArray[5].ToString();
                int nroAfiliado = Convert.ToInt32(row.ItemArray[6]);
                Clientes cliente = new Clientes(clienteId, personaId, nombrePers, nroAfiliado, oSociales);



                int fPagoId = Convert.ToInt32(row.ItemArray[7]);
                string fPago = row.ItemArray[8].ToString();
                FormaPagos formaPago = new FormaPagos(fPagoId, fPago);



                int fEntregaId = Convert.ToInt32(row.ItemArray[9]);
                string fEntrega = row.ItemArray[10].ToString();
                FormaEntregas formaEntrega = new FormaEntregas(fEntregaId, fEntrega);



                int mPagoId = Convert.ToInt32(row.ItemArray[11]);
                string mPago = row.ItemArray[12].ToString();
                MedioPagos medioPago = new MedioPagos(mPagoId, mPago);



                int farmaceuticoId = Convert.ToInt32(row.ItemArray[13]);
                string nomFarmaceutico = row.ItemArray[14].ToString();
                Farmaceuticos farma = new Farmaceuticos(farmaceuticoId, nomFarmaceutico);



                int medicamentoId = Convert.ToInt32(row.ItemArray[15]);
                string nombreMedic = row.ItemArray[16].ToString();
                bool bajoReceta = Convert.ToBoolean(row.ItemArray[17]);
                double precio = Convert.ToDouble(row.ItemArray[18]);
                int stock = Convert.ToInt32(row.ItemArray[19]);
                
                Medicamentos medic = new Medicamentos(medicamentoId, nombreMedic, bajoReceta, precio, stock);



                int cantidad= Convert.ToInt32(row.ItemArray[20]);
                List<DetallePresupuesto> detPresup = new List<DetallePresupuesto>();

                foreach (DetallePresupuesto dt in detPresup)
                {
                    dt.Medicamento.MedicamentosId = medicamentoId;
                    dt.Medicamento.NombreMedic = nombreMedic;
                    dt.Medicamento.BajoReceta= bajoReceta;
                    dt.Medicamento.Precio = precio;
                    dt.Medicamento.Stock = stock;
                    dt.Cantidad = cantidad;

                    detPresup.Add(dt);
                }
                



                int presupId = Convert.ToInt32(row.ItemArray[21]);
                DateTime fechaPresup = Convert.ToDateTime(row.ItemArray[22]);
                double subTotal = Convert.ToDouble(row.ItemArray[23]);
                double Total = Convert.ToDouble(row.ItemArray[24]);
                bool estadoPresup = Convert.ToBoolean(row.ItemArray[25]);
                MaestroPresupuesto mPresup = new MaestroPresupuesto(presupId, clienteId, fechaPresup, formaPago, Total,
                estadoPresup, detPresup, medioPago, formaEntrega, cliente, subTotal, farma);



                lMaestroPresupuesto.Add(mPresup);

            }

            return lMaestroPresupuesto;

        }
    }
    
}
