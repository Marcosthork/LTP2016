using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TesteEstruturaDeDados
    {
        public void chamarVetor()
        {
            //Criar um array - Vetor
            string[] vetor = new string[2];

            String sobrenome = "";

            for (int i = 0; i < vetor.Length-1; i++)
            {
                vetor[i] = "João";
                sobrenome = vetor[i];
            }

            int valor = 0;
            int[] vet = { 1, 3, 5, 7, 9 };
            foreach (int j in vet)
            {
                valor = j;
            }
        }

        public void chamarTabela()
        {
            //Criar um ArrayBidimensional - Matriz ou Tabela
            string[,] tabela = new string[3, 3];

            String outroNome = "";
            for (int j = 0; j < tabela.Length - 1; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    tabela[0, 0] = "Nome";
                    outroNome = tabela[j, k];
                }
            }


        }
    }
}
