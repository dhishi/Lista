using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.ENT;
using WebApplication3.BLL;


namespace WebApplication3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<TipoRestauranteENT> ListoTipoRestaurante = new RestauranteBLL().NGListaTiposRestaurantes();
            
        }

        protected void BtnLista_Click(object sender, EventArgs e)
        {
            List<RestauranteENT> ListoRestaurantes = new RestauranteBLL().NGListaRestaurantes();
            GdvPedidos.DataSource = ListoRestaurantes;

            GdvPedidos.DataBind();
        }
    }
}