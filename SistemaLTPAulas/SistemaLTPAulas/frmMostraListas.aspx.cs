using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTesteAulaLTP
{
    public partial class frmMostraListas : System.Web.UI.Page
    {
        List<ListItem> nomes = new List<ListItem>();
        List<ListItem> logradouros = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                nomes.Add(new ListItem("SELECIONE", ""));
                nomes.Add(new ListItem("Goiás", "GO"));
                nomes.Add(new ListItem("Minas Gerais", "MG"));
                nomes.Add(new ListItem("São Paulo", "SP"));

                logradouros.Add(new ListItem("SELECIONE", ""));
                logradouros.Add(new ListItem("Rua", "RUA"));
                logradouros.Add(new ListItem("Avenida", "Av."));
                logradouros.Add(new ListItem("Praça", "Pç."));

                lstUsuarios.DataSource = nomes;
                lstUsuarios.DataBind();

                ddlUsuarios.DataSource = logradouros;
                ddlUsuarios.DataBind();
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = "" + lstUsuarios.SelectedIndex;
            lblNome.Text = lstUsuarios.SelectedValue;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = "" + ddlUsuarios.SelectedIndex;
            lblNome.Text = ddlUsuarios.SelectedValue;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if(ddlUsuarios.SelectedIndex == 0)
            {
                lblNome.Text = "Selecione o Logradouro";
                lblMsg.Visible = true;
            }
            else
            {
                lblMsg.Visible = false;
            }

            if(ddlUsuarios.SelectedValue == "SELECIONE")
            {

            }
        }
    }
}