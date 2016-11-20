using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace SistemaTesteAulaLTP
{
    public partial class frmAulaListaEstrutura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.nome = txtNome.Text;
            //user.setRG(txtRG.Text);

            AulaListaEstrutura obj = new AulaListaEstrutura();
            obj.manipulaALista(user);
            obj.removerDaLista(user);

            Response.Write(obj.removeATdaLista());
        }
    }
}