using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class EstruturaDadosAvancado
    {

        string[] array = new string[4];
        string nome = "";
        string[,] matriz = new string[2,2];

        public void manipulaVetor()
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                array[i] = "Nome";
                nome = array[i];
            }

            int[] j = { 1, 3, 5, 7, 9 };
            foreach (int elementos in j)
            {
                nome = Convert.ToString(elementos);
            }

        }

        public void manipulaMatriz()
        {
            for(int j = 0; j < matriz.Length; j++)
            {
                for(int k=0; k < 3; k++)
                {
                    matriz[j, k] = "Dia";
                    nome = matriz[0, 1];
                }
            }
        }
         
    }
}
