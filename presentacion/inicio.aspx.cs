using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace presentacion
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string clave = txtClave.Text;

            int usuarioId = ClsLogin.IniciarSesion(cedula, clave);
            if(usuarioId == 0)
            {
                Response.Write("<script> alert(" + "'Datos Incorrectos'" + ") </script>");
            }
            else
            {
                Session["id_persona"] = usuarioId;
                Response.Redirect("~/pages/inicio/sistema.aspx");
            }
        }
    }
}