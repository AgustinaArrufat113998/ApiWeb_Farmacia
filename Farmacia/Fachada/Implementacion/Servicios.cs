
using Farmacia.Datos;
using Farmacia.Datos.Implementacion;
using Farmacia.Datos.Interfaces;
using Farmacia.Dominio;
using Farmacia.Fachada.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Fachada.Implementacion
{
    public class Servicios : IServicios
    {

        private static IDao dao;

        public Servicios()
        {
            dao = new Dao();
        }

       





        //public bool EliminarRegistro(MaestroPresupuesto oVentas)
        //{
        //    return dao.EliminarRegistro(oVentas);
        //}

        public List<Clientes> ListarClientes(string SP)
        {
            return dao.ObtenerClientes(SP);
        }

        public List<Farmaceuticos> ListarFarmaceuticos(string SP)
        {
            return dao.ObtenerFarmaceuticos(SP);
        }

        public List<FormaEntregas> ListarFormaEntregas(string SP)
        {
            return dao.ObtenerFormaEntregas(SP);
        }

        public List<FormaPagos> ListarFormaPagos(string SP)
        {
            return dao.ObtenerFormaPagos(SP);
        }

        public List<Laboratorios> ListarLaboratorios(string SP)
        {
            return dao.ObtenerLaboratorio(SP);
        }

        public List<Medicamentos> ListarMedicamentos(string SP)
        {
            return dao.ObtenerMedicamentos(SP);
        }

        public List<MedioPagos> ListarMedioPago(string SP)
        {
            return dao.ObtenerMediosPago(SP);
        }

        public List<ObrasSociales> ListarObrasSociales(string SP)
        {
            return dao.ObtenerObrasSociales(SP);
        }

        public List<MaestroPresupuesto>BuscarPresupuesto(string sp, List<ParamBusquedaPresup> ListaParametros)
        {
            return dao.ObtenerPresupuesto(sp,ListaParametros);
        }

        public int ProxNroPresup(string sp)
        {
            return dao.ObtenerProxNroPresup(sp);
        }

        public bool RegistrarMedicamentos(MaestroPresupuesto oPresupuesto)
        {
            return dao.RegistrarMedicamentos(oPresupuesto);
        }

        public List<MaestroPresupuesto> BuscarPresupuesto(List<ParamBusquedaPresup> ListaParametros)
        {
            throw new NotImplementedException();
        }
    }
}
