using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;

namespace WebApplication3.DAO
{
    public class Conexao
    {
        public SqlConnection con = new SqlConnection();

        public string Conectar()
        {


            string ConString = ConfigurationManager.AppSettings["appConexao"];

            if (ConString == null && ConfigurationManager.ConnectionStrings["ConnectionString"] != null)
                ConString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;


            //if (String.IsNullOrEmpty(ConString))
            //    ConString = "Server=10.10.0.10;Database=bd_IntranetMutual;UID=intranet;PWD=intranetmutseg";
            con.ConnectionString = ConString;

            try
            {
                con.Open();

                string conStatus = "Conectado";
                return conStatus;
            }

            catch (SqlException erro)
            {
                string conStatus = "<b>Erro de Classe - WMClass.Conexao.Conectar(): </b>" + erro.Message;
                return conStatus;
            }
        }

        public void Desconectar()
        {
            con.Close();
        }


    }
}