using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    

    public  class Personas

    {      
     
        public Personas(int personaId,string nombre) 
        {
            PersonaId = personaId;
            Nombre = nombre;
            
        }   


        public Personas(int personaId,long dniCuil, string nombre, string direccion, int numDireccion, long telefono, string email)
        {
            DniCuil = dniCuil;
            Nombre = nombre;
            Direccion = direccion;
            NumDireccion = numDireccion;
            Telefono = telefono;
            Email = email;
            PersonaId = personaId;
        }



        public int PersonaId { get; set; }
        public long DniCuil { get; set; }       
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int NumDireccion { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }



    }
}
