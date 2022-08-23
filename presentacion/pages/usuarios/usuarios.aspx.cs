using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Modelo;

namespace presentacion.pages.usuarios
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarSesion();
            Listar();
        }
        private void VerificarSesion()
        {
            if (Session["id_persona"] == null)
            {
                Response.Redirect("~/inicio.aspx");
            }
        }
        private void Listar()
        {
            gvUsuarios.DataSource = null;
            gvUsuarios.DataBind();

            int usuarioId = int.Parse(Session["id_persona"].ToString());
            gvUsuarios.DataSource = ClsUsuario.ListaUsuarios(usuarioId);
            gvUsuarios.DataBind();
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = gvUsuarios.SelectedRow;
            string nombre = fila.Cells[2].Text;
            Response.Write("<script> alert(" + "'El nombre del usuario es: '" + nombre + ")</script>");
        }
    }
}