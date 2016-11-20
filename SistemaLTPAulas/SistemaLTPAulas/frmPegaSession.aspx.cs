using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTesteAulaLTP
{
    public partial class frmPegaSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = (string) Session["Usuario"];

            try {
                Application["ContadorDeAcesso"] = (int)Application["ContadorDeAcesso"] + 1;
            } catch (Exception ex){
                Application["ContadorDeAcesso"] = 1;
            }

            lblVisitas.Text = Convert.ToString(Application["ContadorDeAcesso"]);
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmSession.aspx");
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = "";
            gravaCookie("");
            Response.Redirect("frmSession.aspx");

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
    }
}