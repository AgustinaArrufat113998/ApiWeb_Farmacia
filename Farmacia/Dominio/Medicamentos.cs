using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Dominio
{
    public class Medicamentos
    {
        int medicamentosId = 0;
        string nombreMedic="";
        bool bajoReceta=false;
        double precio = 0;
        int stock = 0;
        Laboratorios labo = null;
        Presentaciones present = null;


        public Medicamentos(int medicamentosId, string nombreMedic, bool bajoReceta,double precio, int stock)
        {
            MedicamentosId = medicamentosId;
            NombreMedic = nombreMedic;
            BajoReceta = bajoReceta;
            Precio = precio;
            Stock = stock;

        }


        public Medicamentos( int medicamentosId, string nombreMedic, DateTime fechaVto, bool bajoReceta, Presentaciones present, Laboratorios labo,int stock,double precio)
        {
            MedicamentosId = medicamentosId;
            NombreMedic = nombreMedic;
            FechaVto = fechaVto;
            BajoReceta = bajoReceta;
            Present = present;
            Labo = labo;
            Stock = stock;
            Precio = precio;
        }

        public int MedicamentosId { get; set; }
        public string NombreMedic { get; set; }      
        public DateTime FechaVto { get; set; }
        public bool BajoReceta { get; set; }
        public Presentaciones Present { get; set; }
        public Laboratorios Labo { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }





    }
}
