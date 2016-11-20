using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace SistemaTesteAulaLTP
{
    public partial class frmCadAluno : System.Web.UI.Page
    {
        /*List<dynamic> dynList = new List<dynamic>() {
            new {Id = 1, Name = "Elevator", Company="Vertical Pop" },
            new {Id = 2, Name = "Stairs", Company="Fitness" }
            };
            */
        List<ListItem> nomes = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //ListBox com List<T>
                nomes.Add(new ListItem("Eu", "0"));
                nomes.Add(new ListItem("Nós", "1"));
                nomes.Add(new ListItem("Vós", "2"));
                lstUsuarios.DataSource = nomes;
                lstUsuarios.DataBind();

                //lstUsuarios.DataSource = dynList;
                //lstUsuarios.DataTextField = "Name";
                //lstUsuarios.DataValueField = "Id";

                //DropDownList com List<T>
                ddlUsuarios.DataSource = nomes;
                ddlUsuarios.DataBind();
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuarios objUsuario = new Usuarios();
            //objUsuario.Nome = "Norton";
            //objUsuario.setUsuario("@nortong");
            objUsuario.cadastrar();
        }

        protected void btnChamarVetor_Click(object sender, EventArgs e)
        {
            //TesteEstruturaDeDados estrutura = new TesteEstruturaDeDados();
            //estrutura.chamarVetor();

            Negocio.EstruturaDadosAvancado objeto = new Negocio.EstruturaDadosAvancado();
            objeto.manipulaVetor();

            Negocio.ListasColecoes obj = new Negocio.ListasColecoes();
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = "" + lstUsuarios.SelectedIndex;
            lblNome.Text = lstUsuarios.SelectedValue;
        }

        protected void ddlUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = "" + ddlUsuarios.SelectedIndex;
            lblNome.Text = ddlUsuarios.SelectedValue;
        }
    }
}