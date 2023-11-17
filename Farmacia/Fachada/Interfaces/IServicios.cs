using Farmacia.Datos;
using Farmacia.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Fachada.Interfaces
{
    public interface IServicios
    {
        List<Clientes> ListarClientes(string SP);
        List<Farmaceuticos> ListarFarmaceuticos(string SP);
        List<MedioPagos>ListarMedioPago(string SP);
        List<ObrasSociales> ListarObrasSociales(string SP);
        List<Medicamentos> ListarMedicamentos(string SP);
        List<Laboratorios> ListarLaboratorios(string SP);
        List<FormaPagos>ListarFormaPagos(string SP);
        List<FormaEntregas>ListarFormaEntregas(string SP);


        bool RegistrarMedicamentos(MaestroPresupuesto oVentas);
       // bool EliminarRegistro(MaestroPresupuesto oPresupuesto);
        int ProxNroPresup(string sp);
       
        List<MaestroPresupuesto>BuscarPresupuesto(List<ParamBusquedaPresup> ListaParametros);
        
    }
}
