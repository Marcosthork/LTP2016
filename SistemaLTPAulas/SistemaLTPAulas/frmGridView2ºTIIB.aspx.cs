using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace SistemaTesteAulaLTP
{
    public partial class frmGridView2ºTIIB : System.Web.UI.Page
    {
        List<Usuarios> listaUsuarios = new List<Usuarios>();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaUsuarios.Add(new Usuarios { CPF = "1234", nome = "Paulo", RG = "123", senha = "123", usuario = "@pauo123" });
            listaUsuarios.Add(new Usuarios { CPF = "43423", nome = "Maria", RG = "123", senha = "123", usuario = "@paulinho123" });
            listaUsuarios.Add(new Usuarios { CPF = "333", nome = "José", RG = "123", senha = "123", usuario = "@pa123" });
            listaUsuarios.Add(new Usuarios { CPF = "3434", nome = "Filho", RG = "123", senha = "123", usuario = "@paulo123" });
            listaUsuarios.Add(new Usuarios { CPF = "2323", nome = "Do", RG = "123", senha = "123", usuario = "@painho123" });
            listaUsuarios.Add(new Usuarios { CPF = "32323", nome = "Pai", RG = "123", senha = "123", usuario = "@panho123" });

            gdvUsuarios.DataSource = listaUsuarios;
            gdvUsuarios.DataBind();

            gdvUsuarios.SelectedIndex = 4;
        }

        protected void gdvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Text = gdvUsuarios.SelectedRow.Cells[1].Text;
            lblUsuario.Text = gdvUsuarios.SelectedRow.Cells[4].Text;
        }
    }
}