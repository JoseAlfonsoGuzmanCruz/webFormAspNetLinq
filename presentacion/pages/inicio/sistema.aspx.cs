using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace presentacion.pages.inicio
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarSesion();
            if (!Page.IsPostBack)
            {
                int usuarioId = int.Parse(Session["id_persona"].ToString());
                persona persona = ClsUsuario.BuscarPorId(usuarioId);
                //lblNombre.Text = Session["id_persona"].ToString();
                lblNombre.Text = "Hola" + persona.nombre;
            }
        }

        private void VerificarSesion()
        {
            if (Session["id_persona"] == null)
            {
                Response.Redirect("~/inicio.aspx");
            }
        }
    }
}