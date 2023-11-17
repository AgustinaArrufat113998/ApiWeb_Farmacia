﻿
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmaciaWebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmaciaPresupuesto : ControllerBase
    {
        private IServicios service;

        public FarmaciaPresupuesto()
        {

            service = new Iservicios();
        }
        // o //public FarmaciaPresupuesto(servicefartoryImp factory)
        // factory.CrearService();
        //}



        // GET api/<FarmaciaPresupuesto>/5
        [HttpGet("{medicamentos}")]
        public IActionResult GetMedicamentos()
        {
            return Ok(service.ListarMedicamentos);
        }

        [HttpGet("{Clientes}")]
        public IActionResult GetClientes ()
        {
            return Ok(service.ObtenerClientes);
        }

        [HttpGet("{Laboratorios}")]
        public IActionResult GetLaboratorio()
        {
            return Ok(service.ObtenerLaboratorio);
        }

        [HttpGet("{ObrasSociales}")]
        public IActionResult GetObrasSociales()
        {
            return Ok(service.ObtenerObrasSociales);
        }

        [HttpGet("{FormaPagos}")]
        public IActionResult GetFormaPagos()
        {
            return Ok( service.ObtenerFormaPagos);
        }

        [HttpGet("{FormaEntregas}")]
        public IActionResult GetFormaEntregas()
        {
            return Ok(service.ObtenerFormaEntregas);
        }



        [HttpGet("{Farmaceuticos}")]
        public IActionResult GetFarmaceuticos()
        {
            return Ok( service.ObtenerFarmaceuticos);
        }


         [HttpGet("{}")]
        public IActionResult Get()
        {
            return Ok(service.Obtener);
        }


        [HttpPost("{ id}")] //POR GET PARA BUSCAR UNO
        public IActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest(" Se requieren id");
            return Ok(service.BuscarPresupuestoporId(id));
            // es necesario crear el metodo 

        }


        [HttpPost("Consultar presupuestos")] // POR POST A CONSULTAR TODO
        // Y EN EL CUERPO ESTAMOS MANDANDO UNA LISTA DE PARAMETROS PARA BUSCAR EL PRESUPUESTO
        public IActionResult GetPresupuestos(List<ParamBusquedaPresup> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest(" Se requieren parametros");
            return Ok(service.BuscarPresupuesto(lst));

        }

        // POST api/<FarmaciaPresupuesto> 
        [HttpPost]
        public IActionResult PostDetallePresupuesto(DetallePresupuesto oDetallePresupuesto)
        {
            if (oDetallePresupuesto == null)
            {
                return BadRequest();
            }

            if (service.RegistrarPresupuesto(oDetallePresupuesto))
            return Ok(" El pedido se ingreso exitosamente");
            else
                return Ok("No se pudo ingresar su pedido");
        }

        [HttpPost]
        public IActionResult PostRegistrarMedicamentos(MaestroPresupuesto oVentas)
        {
            if (oVentas == null)
            {
                return BadRequest();
            }

            if (service.RegistrarMedicamentos(oVentas))// o grabar   
             return Ok(" El medicamento se ingreso exitosamente");
            
            else
                return Ok("No se pudo ingresar su medicamento");
        }

        [HttpPost]
        public IActionResult PostRegistrarMedicamentos(MaestroPresupuesto oVentas)
        {
            if (oVentas == null)
            {
                return BadRequest();
            }

            if (service.RegistrarMedicamentos(oVentas))// o grabar   
                return Ok(" El medicamento se ingreso exitosamente");

            else
                return Ok("No se pudo ingresar su medicamento");
        }


        //ListarClientes(string SP);
        // ListarFarmaceuticos(string SP);
        // ListarMedioPago(string SP);
        // ListarObrasSociales(string SP);
        // ListarMedicamentos(string SP);
        //ListarLaboratorios(string SP);
        //ListarFormaPagos(string SP);
        //ListarFormaEntregas(string SP);

        //bool RegistrarMedicamentos(MaestroPresupuesto oVentas);
        //List<MaestroPresupuesto> BuscarPresupuesto(string sp, List<ParamBusquedaPresup> ListaParametros);
        //public bool DescontarStockMedicamentos(string sp, int cantidad, int id_medicamento)

        //int ProxNroPresup(string sp);




        //// bool EliminarRegistro(MaestroPresupuesto oPresupuesto);

        // DELETE api/<FarmaciaPresupuesto>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest(" Se requieren id");
            return Ok(service.EliminarRegistro(id));
        }
    }
}



