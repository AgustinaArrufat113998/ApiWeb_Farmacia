using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Datos
{
    public class HelperDao
    {

        //Singleton para conectar a la base
        private static SqlConnection conexion=null;
        private static HelperDao instancia=null;

        private HelperDao()
        {         
           conexion = new SqlConnection("cadenaconexion");
          
        }


        public static HelperDao ObtenerInstancia()
        {
            if(instancia==null)
            {
                instancia= new HelperDao();
            }
            return instancia;
        }

        //Llena combos de distintas tablas de la base
        public DataTable LlenarCombo(string SP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = SP;
            comando.Connection = this.obtenerConexion();
            
            DataTable tabla=new DataTable();

            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
           
        }


        //Realiza conexion a base
        public SqlConnection obtenerConexion()
        {
          return conexion;
        }


        //Buscar presupuesto en la base indicando nro presupuesto / fechas y nombre
        public DataTable BuscarPresupuesto(string sp,List<ParamBusquedaPresup>lParametros)
        {
        
            this.obtenerConexion();
            DataTable tabla= new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandType= CommandType.StoredProcedure;
            comando.CommandText= sp;

            if(lParametros!=null)
            {
                foreach (ParamBusquedaPresup oParametro in lParametros)
                {
                    comando.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);

                }
            }

            tabla.Load(comando.ExecuteReader());


            conexion.Close();



            return tabla;

        
        }



        //Buscar proximo presupuesto
        public int ProxNroPresup(string sp)
        {
            SqlParameter parametro= new SqlParameter();
            SqlCommand comando=new SqlCommand();
            comando.Connection = this.obtenerConexion();
            conexion.Open();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
            parametro.DbType= DbType.Int32;
            parametro.Direction = ParameterDirection.Output;
            parametro.ParameterName = "next";
            comando.Parameters.Add(parametro);
            comando.ExecuteReader();
            conexion.Close();

            return (int)parametro.Value;
        }

        //public int ObtenerEscalar(string sentencia, string nomParam)
        //{
        //    int aux = 0;
        //    Conectar();
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = conexion;
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.CommandText = sentencia;
        //    SqlParameter param = new SqlParameter(nomParam, SqlDbType.Int);
        //    param.Direction = ParameterDirection.Output;
        //    comando.Parameters.Add(param);
        //    comando.ExecuteNonQuery();
        //    Desconectar();
        //    aux = (int)param.Value;
        //    return aux;
        //}

    }
}
