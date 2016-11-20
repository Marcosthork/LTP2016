using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pUsuarios
    {
        public String nome;
        private String rg;
        private String cpf;
        private String usuario;
        private String senha;

        public String Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }

        public void setRG(String rg)
        {
            this.rg = rg;
        }

        public String getRG()
        {
            return this.rg;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public void cadastrar()
        {
            //Aqui realiza a conexão com o BD
            //E grava na tabela desejada
            String sql = "INSERT INTO usuario set nome='"+this.nome+"'";
            //ADO.NET
         


        }
    }
}
