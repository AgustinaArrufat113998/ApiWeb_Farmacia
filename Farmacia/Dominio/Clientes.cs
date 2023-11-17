using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class Clientes : Personas
    {
       

        public Clientes(int clienteId, int personaId, string nombre,int nroAfiliado):base(personaId,nombre)
        {

            ClienteId = clienteId;
            NroAfiliado = nroAfiliado;
        }


        public Clientes(int clienteId, int personaId, string nombre, int nroAfiliado,ObrasSociales obraSocial) : base(personaId, nombre)
        {

            ClienteId = clienteId;
            NroAfiliado = nroAfiliado;
            ObraSocial = obraSocial;
        }

        public Clientes(int clienteId, int nroAfiliado, ObrasSociales obraSocial,int personaId,long dniCuil,string nombre, string direccion,int numDireccion,long telefono,string email):base(personaId, dniCuil,nombre,direccion, numDireccion, telefono, email)
        {
            ClienteId = clienteId;
            NroAfiliado = nroAfiliado;
            ObraSocial = obraSocial;
            
           
            
        }

      


        public  int ClienteId  { get; set; }
        public  int NroAfiliado { get; set; }             
        public ObrasSociales? ObraSocial { get; set; }


    }
}
