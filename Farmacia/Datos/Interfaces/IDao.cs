
using Farmacia.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Datos.Interfaces
{
    public interface IDao
    {
        
        //bool EliminarRegistro(MaestroPresupuesto oVentas);
        List<Clientes> ObtenerClientes(string SP);
        List<Farmaceuticos> ObtenerFarmaceuticos(string SP);
        List<FormaEntregas> ObtenerFormaEntregas(string sP);
        List<FormaPagos> ObtenerFormaPagos(string sP);
        List<Laboratorios> ObtenerLaboratorio(string sP);
        List<Medicamentos> ObtenerMedicamentos(string sP);
        List<MedioPagos> ObtenerMediosPago(string sP);
        List<ObrasSociales> ObtenerObrasSociales(string SP);
        int ObtenerProxNroPresup(string sp);
        List<MaestroPresupuesto>ObtenerPresupuesto(string sp, List<ParamBusquedaPresup> ListaParametros);
        bool RegistrarMedicamentos(MaestroPresupuesto oPresupuesto);
        
    }
}
