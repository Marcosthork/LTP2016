using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AulaListaEstrutura
    {
        List<Usuarios> lista = new List<Usuarios>();

        public void manipulaALista(Usuarios item)
        {
            lista.Add(item);
        }

        public void removerDaLista(Usuarios item)
        {
            lista.Remove(item);
        }
        
        public String removeATdaLista()
        {
            String msg = "";
            try {
                lista.RemoveAt(0);
            }
            catch(NullReferenceException e)
            {
                msg = "Valor nulo";
            }
            catch(ArgumentOutOfRangeException e)
            {
                msg = "Lista não declarada";
                //Envia e-mail para o Administrado;
            }
            catch(Exception e)
            {
                msg = "Valor Genérico";
            }

            return msg;

        }
    }
}
