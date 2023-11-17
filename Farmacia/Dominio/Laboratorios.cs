using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class Laboratorios
    {
        public Laboratorios(long laboratorioId, string nombreLab)
        {
            LaboratorioId = laboratorioId;
            NombreLab = nombreLab;
            
        }

        public long LaboratorioId { get; set; }
        public string NombreLab { get; set; }
        







    }
}
