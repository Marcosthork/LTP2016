using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTesteAulaLTP
{
    public partial class frmSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitas.Text = Convert.ToString(Application["ContadorDeAcesso"]);

            if (pegaCookie() != "Vazio")
            {
                Session["Usuario"] = pegaCookie();
                Response.Redirect("frmPegaSession.aspx");
            }
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = txtUsuario.Text;

            if (chkManterLogado.Checked)
            {
                gravaCookie(txtUsuario.Text);
            }

            Response.Redirect("frmPegaSession.aspx");
        }

        public void gravaCookie(String texto)
        {
            //Cria um novo cookie, passando o nome no construtor
            HttpCookie cookie = new HttpCookie("Usuario");

            //Determina o valor o cookie
            cookie.Value = texto;

            //Configura o cookie para expirar em 1 minuto
            DateTime dtNow = DateTime.Now;
            TimeSpan tsMinute = new TimeSpan(0, 0, 1, 0);
            cookie.Expires = dtNow + tsMinute;
            
            //Adiciona o cookie
            Response.Cookies.Add(cookie);
        }

        public String pegaCookie()
        {
            //Captura o cookie
            HttpCookie cookie = Request.Cookies["Usuario"];

            String strCookieValue = "Vazio";

            //Certifica-se que o cookie existe
            if (cookie != null)
            {
                if(cookie.Value != "")
                    strCookieValue = cookie.Value.ToString();
            }

            return strCookieValue;
        }
    }
}