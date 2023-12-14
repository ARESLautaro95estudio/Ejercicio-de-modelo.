using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Exceptions;

namespace Entidades.DataBase
{
    //8.DataBaseManager será estática:
    //  a.En el constructor de clase inicializar el string connection.
    //  b.GetNuevaPalabra, recibirá el nombre de la tabla sobre la cual realizar el select y
    //  el id de la palabra a obtener. Retornada la palabra leída desde la BD.

    public static class DataBaseManager
    {
        private static string stringConexion ;
        private static SqlConnection connection;
        static DataBaseManager()
        {
            DataBaseManager.stringConexion = "Server=.\\MSSQLSERVER01;Database=integrador_DB ;Trusted_Connection=True;";
        }
        public static string GetNuevaPalabra(string tabla , int id)
        { 
            string QWERY = $"SELECT *  FROM  {tabla} where id ={id}";

            DataBaseManager.connection= new SqlConnection(DataBaseManager.stringConexion);

            SqlCommand comando = new SqlCommand(QWERY, DataBaseManager.connection);

            SqlDataReader lectura = comando.ExecuteReader();

            return lectura.GetString(1);
        }
    }
}
