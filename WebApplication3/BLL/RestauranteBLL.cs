using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.DAO;
using WebApplication3.ENT;

namespace WebApplication3.BLL
{
    public class RestauranteBLL
    {
        public List<RestauranteENT> NGListaRestaurantes(int? IntTipoRestaurante = null, String StrNmRestaurante = null)
        {
            return new RestauranteDAO().ListaRestaurantes(IntTipoRestaurante,StrNmRestaurante);
        }
        public List<TipoRestauranteENT> NGListaTiposRestaurantes(int? IntTipoRestaurante = null, String StrNmRestaurante = null)
        {
            return new RestauranteDAO().ListaTiposRestaurantes(IntTipoRestaurante, StrNmRestaurante);
        }
    }
}