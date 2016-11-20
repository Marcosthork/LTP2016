using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTesteAulaLTP
{
    public partial class frmGridView : System.Web.UI.Page
    {
        List<Negocio.Usuarios> listaUsuarios = new List<Negocio.Usuarios>();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaUsuarios.Add(new Negocio.Usuarios { CPF = "0123456789-09", nome = "Norton", RG = "3254697", senha = "123456789", usuario = "@nortoncg" });
            listaUsuarios.Add(new Negocio.Usuarios { CPF = "0123456789-09", nome = "Judas", RG = "3254697", senha = "123456789", usuario = "@nortoncg" });
            listaUsuarios.Add(new Negocio.Usuarios { CPF = "0123456789-09", nome = "Maria", RG = "3254697", senha = "123456789", usuario = "@nortoncg" });
            listaUsuarios.Add(new Negocio.Usuarios { CPF = "0123456789-09", nome = "José", RG = "3254697", senha = "123456789", usuario = "@nortoncg" });

            gdvUsuarios.DataSource = listaUsuarios;
            gdvUsuarios.DataBind();           
        }

        protected void gdvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
             txtNome.Text = gdvUsuarios.SelectedRow.Cells[1].Text;
             txtUsuario.Text = gdvUsuarios.SelectedRow.Cells[4].Text;
        }
    }
}