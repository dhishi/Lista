using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication3.ENT;

namespace WebApplication3.DAO
{
    public class RestauranteDAO : Conexao
    {
        public List<RestauranteENT> ListaRestaurantes(int? IntTipoRestaurante = null, String? StrNmRestaurante)
        {
            try
            {

                Conectar();
                SqlCommand oSqlCommand = new SqlCommand("usp_ListaRestaurantes", con);
                oSqlCommand.CommandTimeout = 300000;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                //oSqlCommand.Parameters.AddWithValue("@Dt_Fim", DtFim);
                //oSqlCommand.Parameters.AddWithValue("@dt_fim", datafim);


                SqlDataReader dr = oSqlCommand.ExecuteReader();

                List<RestauranteENT> Lista = new List<RestauranteENT>();

                while (dr.Read())
                {
                    RestauranteENT c = new RestauranteENT();
                    c.IntTipoRestaurante = Convert.ToInt16(dr[""]);
                    c.StrRestaurante = dr[""] != DBNull.Value ? (string)dr[""] : string.Empty;
                    c.StrTelefoneRestaurante = dr[""] != DBNull.Value ? (string)dr[""] : string.Empty;
                    
                    
                    //c.DblApolice = dr["cd_apolice"] != DBNull.Value ? Convert.ToDouble(dr["cd_apolice"]) : 0;
                    //c.DtInicioVigencia = dr["dt_inicio_vigencia"] != DBNull.Value ? (Convert.ToDateTime(dr["dt_inicio_vigencia"])).ToString("dd/mm/yyyy") : string.Empty;  //Convert.ToDateTime(dr["dt_inicio_vigencia"]);
                    //c.DblSinistro = dr["nr_sinistro"] != DBNull.Value ? Convert.ToDouble(dr["nr_sinistro"]) : 0;
                    //c.DtOcorrencia = dr["Dt_ocorrencia"] != DBNull.Value ? (Convert.ToDateTime(dr["Dt_ocorrencia"])).ToString("dd/mm/yyyy") : string.Empty;  //Convert.ToDateTime(dr["Dt_ocorrencia"]);

                    //c.DtAviso = dr["Dt_Aviso"] != DBNull.Value ? (Convert.ToDateTime(dr["Dt_Aviso"])).ToString("dd/mm/yyyy") : string.Empty; //Convert.ToDateTime(dr["Dt_Aviso"]);
                    //c.IntDiasOcorrenciaInicioVigencia = Convert.ToInt16(dr["Dias -> Ocorrência - Inicio vigencia"]);
                    //c.IntDiasAvisoOcorrencia = Convert.ToInt16(dr["Dias -> Aviso - Ocorrência"]);
                    //c.IntDiasHojeOcorrencia = Convert.ToInt16(dr["Dias -> Hoje - Ocorrência"]);
                    //c.DblIndenizado = dr["Indenizado"] != DBNull.Value ? Convert.ToDouble(dr["Indenizado"]) : 0;
                    //c.DblEstornoIndenizacao = dr["Estorno Indenização"] != DBNull.Value ? Convert.ToDouble(dr["Estorno Indenização"]) : 0;
                    //c.DblDespesas = dr["Despesas"] != DBNull.Value ? Convert.ToDouble(dr["Despesas"]) : 0;
                    //c.DblHonorarios = dr["Honorários"] != DBNull.Value ? Convert.ToDouble(dr["Honorários"]) : 0;
                    //c.DblRessarcimento = dr["Ressarcimento"] != DBNull.Value ? Convert.ToDouble(dr["Ressarcimento"]) : 0;
                    //c.DblAviso = dr["Aviso"] != DBNull.Value ? Convert.ToDouble(dr["Aviso"]) : 0;
                    //c.DblReserva = dr["vlr_reserva"] != DBNull.Value ? Convert.ToDouble(dr["vlr_reserva"]) : 0;
                    //c.StrStatus = dr["nm_status"] != DBNull.Value ? (string)dr["nm_status"] : string.Empty;
                    //c.StrSegurado = dr["Segurado"] != DBNull.Value ? (string)dr["Segurado"] : string.Empty;
                    //c.StrCorretor = dr["Corretor"] != DBNull.Value ? (string)dr["Corretor"] : string.Empty;
                    //c.StrEstipulante = dr["Estipulante"] != DBNull.Value ? (string)dr["Estipulante"] : string.Empty;
                    //c.StrProduto = dr["Nm_produto"] != DBNull.Value ? (string)dr["Nm_produto"] : string.Empty;


                    Lista.Add(c);
                }

                dr.Dispose();
                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar. Erro :[" + ex.Message + "]");
            }
            finally
            {
                Desconectar();
            }
        }

        public List<TipoRestauranteENT> ListaTiposRestaurantes(int? IdTipoRestaurante = null, String? StrNmRestaurante)
        {
            try
            {

                Conectar();
                SqlCommand oSqlCommand = new SqlCommand("usp_ListaTiposRestaurantes", con);
                oSqlCommand.CommandTimeout = 300000;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                

                oSqlCommand.Parameters.AddWithValue("@Dt_Inicio", DtInicio);
                
                //if(!string.IsNullOrEmpty(tete))
                //    oSqlCommand.Parameters.AddWithValue("@Dt_Fim", tete);
                //oSqlCommand.Parameters.AddWithValue("@dt_fim", datafim);


                SqlDataReader dr = oSqlCommand.ExecuteReader();

                List<TipoRestauranteENT> Lista = new List<TipoRestauranteENT>();

                while (dr.Read())
                {
                    TipoRestauranteENT c = new TipoRestauranteENT();
                    c.IdTipoRestaurante = Convert.ToInt16(dr[""]);
                    c.DscTipoRestaurante = dr[""] != DBNull.Value ? (string)dr[""] : string.Empty;

                    Lista.Add(c);
                }

                dr.Dispose();
                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar Relatório. Erro :[" + ex.Message + "]");
            }
            finally
            {
                Desconectar();
            }

        }
    }
}