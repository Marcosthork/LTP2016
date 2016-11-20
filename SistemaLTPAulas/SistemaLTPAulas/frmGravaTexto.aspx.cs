using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTesteAulaLTP
{
    public partial class frmGravaTexto : System.Web.UI.Page
    {
        String nomeArquivoTexto = "TextFile.txt";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                System.IO.DriveInfo drive = new System.IO.DriveInfo(@"C:\");
                lblDriveName.Text = drive.Name;
                lblDriveType.Text = drive.DriveType.ToString();
                lblAvailableFreeSpace.Text = drive.AvailableFreeSpace.ToString();
                lblDriveFormat.Text = drive.DriveFormat;
                lblTotalFreeSpace.Text = drive.TotalFreeSpace.ToString();
                lblTotalSize.Text = drive.TotalSize.ToString();
                lblVolumeLabel.Text = drive.VolumeLabel;
            }
        }

        protected void txtGravaArquivo_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = 
                new System.IO.FileStream(Server.MapPath(nomeArquivoTexto), System.IO.FileMode.Append, 
                System.IO.FileAccess.Write, System.IO.FileShare.Read, 8, System.IO.FileOptions.None);
            byte[] data = System.Text.Encoding.ASCII.GetBytes(txtObsrvacao.Text);
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();

            mostraDadosDoArquivo(nomeArquivoTexto);
        }

        private void mostraDadosDoArquivo(string valor)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(Server.MapPath(valor));
            this.lblLocation.Text = file.FullName;
            this.lblSize.Text = file.Length.ToString();
            this.lblCreated.Text = file.CreationTime.ToString();
            this.lblModified.Text = file.LastWriteTime.ToString();
            this.lblAccessed.Text = file.LastAccessTime.ToString();
            this.lblAttributes.Text = file.Attributes.ToString();
        }

        protected void btnCriaDiretorio_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(MapPath("Wrox"));

            if (System.IO.Directory.Exists(MapPath("Wrox")))
            {
                this.lblDataCriacaoDir.Text = System.IO.Directory.GetCreationTime(MapPath("Wrox")).ToString();
                this.lblUltimoAcesso.Text = System.IO.Directory.GetLastAccessTime(MapPath("Wrox")).ToString();
                this.lblUltimaGravacao.Text = System.IO.Directory.GetLastWriteTime(MapPath("Wrox")).ToString();
            }
        }

        protected void btnApagaDiretorio_Click(object sender, EventArgs e)
        {
            System.IO.Directory.Delete(MapPath("Wrox"));
        }

        protected void btnLerArquivo_Click(object sender, EventArgs e)
        {
            try {
                System.IO.FileStream fs =
                    new System.IO.FileStream(Server.MapPath(nomeArquivoTexto), System.IO.FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();
                this.lblResult.Text = ASCIIEncoding.Default.GetString(data);
            }catch (Exception ex){
                lblResult.ForeColor = System.Drawing.Color.Red;
                this.lblResult.Text = "Arquivo não encontrado";
            }
        }

        protected void btnApagaArquivo_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(Server.MapPath(nomeArquivoTexto));
        }
    }
}