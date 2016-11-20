using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace SistemaTesteAulaLTP
{
    public partial class frmManipulaLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Usuarios objUsuario = new Usuarios();
            //objUsuario.setRG(txtRG.Text);
            //objUsuario.setUsuario(txtNome.Text);

            ListasColecoes obj = new ListasColecoes();
            obj.metodoLista(objUsuario);

            obj.buscaLista();
        }
    }
}