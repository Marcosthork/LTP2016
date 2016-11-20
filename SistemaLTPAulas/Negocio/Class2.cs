using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Class2 : ITeste {String nome = ""; public void manipula(){
            Circulo meuCirculo = new Circulo(10);}}

    struct Circulo: ITeste
    {
        private int _raio;      // Atributo

        public double Circunferencia    // Propriedade
        {
            get { return 2 * _raio * Math.PI; }
        }

        // Regra específica para retornar  um valor.
        public Circulo(int raio)    // Construtor com um argumento
        {
            this._raio = raio;
        }  // Atribuição do valor do argumento
    }					// para o atributo do objeto.
}
