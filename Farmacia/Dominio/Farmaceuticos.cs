using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class Farmaceuticos
    {
        string nomFarmaceutico = null;

        public Farmaceuticos(int farmaceuticoId, string nomFarmaceutico)
        {
            FarmaceuticoId = farmaceuticoId;
            NomFarmaceutico = nomFarmaceutico;
        }

        public  int FarmaceuticoId { get; set; }
        public string NomFarmaceutico { get; set; }
    }
}
