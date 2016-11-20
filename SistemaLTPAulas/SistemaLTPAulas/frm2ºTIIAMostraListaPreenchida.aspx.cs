using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTesteAulaLTP
{
    public partial class frm2ºTIIAMostraListaPreenchida : System.Web.UI.Page
    {
        List<ListItem> usuarios = new List<ListItem>();
        List<ListItem> logradouros = new List<ListItem>();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                usuarios.Add(new ListItem("Eu", "1"));
                usuarios.Add(new ListItem("Tu", "2"));
                usuarios.Add(new ListItem("Eles", "3"));
                usuarios.Add(new ListItem("Nós", "4"));

                lstUsuarios.DataSource = usuarios;
                lstUsuarios.DataBind();

                logradouros.Add(new ListItem("SELECIONE", ""));
                logradouros.Add(new ListItem("Rua", "R"));
                logradouros.Add(new ListItem("Avenida", "Av."));
                logradouros.Add(new ListItem("Praça", "Pç."));
                logradouros.Add(new ListItem("Alameda", "Al."));

                ddlLogradouros.DataSource = logradouros;
                ddlLogradouros.DataBind();
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            if (ddlLogradouros.SelectedValue == "SELECIONE")
            {
                Response.Write("Selecione o Logradouro");
            }
            else
            {
                lblID.Text = "" + ddlLogradouros.SelectedIndex;
                lblTexto.Text = ddlLogradouros.SelectedValue;
            }
        }

        protected void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = "" + lstUsuarios.SelectedIndex;
            lblTexto.Text = lstUsuarios.SelectedValue;
        }
    }
}