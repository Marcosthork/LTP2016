using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Usuarios
    {
        public String nome {get; set;}
        public string RG { get; set; }
        public string CPF { get; set;}
        public string usuario { get; set;}
        public string senha { get; set;}

        public void cadastrar()
        {
            pUsuarios objUsuario = new pUsuarios();
            objUsuario.Nome = this.nome;
            objUsuario.setUsuario(this.usuario);
            objUsuario.cadastrar();
        }
        
    }
}
