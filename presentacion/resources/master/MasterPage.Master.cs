using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace presentacion.resources.master
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_persona"] != null)
            {
                int usuarioId = int.Parse(Session["id_persona"].ToString());
                persona persona = ClsUsuario.BuscarPorId(usuarioId);
                //lblNombre.Text = Session["id_persona"].ToString();
                lblNombre.Text = persona.nombre;
            }
            else
            {
                Response.Redirect("~/inicio.aspx");
            }
        }

        protected void lnkCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/inicio.aspx");
        }
    }
}