using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace SistemaTesteAulaLTP
{
    public partial class EstruturaDadosAvancado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChamarVetor_Click(object sender, EventArgs e)
        {
            Negocio.EstruturaDadosAvancado objeto = new Negocio.EstruturaDadosAvancado();
            objeto.manipulaVetor();
        }
    }
}