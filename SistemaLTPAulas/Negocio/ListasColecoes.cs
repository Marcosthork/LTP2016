using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ListasColecoes
    {
        // cria uma lista que armazena o tipo Conta
        List<Usuarios> lista = new List<Usuarios>();
        
        public void metodoLista(Usuarios item)
        {
            lista.Add(item);
        }

        public List<Usuarios> buscaLista()
        {
            return lista;
        }
    }
}
