using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Asteroides
    {
        private int posicaox ;
        private int posicaoy;
        private int tamanhoAsteroide;
        private int velocidadeAsteroide;
        private int energiaAsteroide;


        public int Posicaox { get => posicaox; set => posicaox = value; }
        public int Posicaoy { get => posicaoy; set => posicaoy = value; }
        public int TamanhoAsteroide { get => tamanhoAsteroide; set => tamanhoAsteroide = value; }
        public int VelocidadeAsteroide { get => velocidadeAsteroide; set => velocidadeAsteroide = value; }
        public int EnergiaAsteroide { get => energiaAsteroide; set => energiaAsteroide = value; }

        public Asteroides()
        {

        }

        public Asteroides(int posicaox, int posicaoy, int tamanhoAsteroide, int velocidadeAsteroide, int energiaAsteroide )
        {
            this.posicaox = posicaox;
            this.posicaoy = posicaoy;
            this.tamanhoAsteroide = tamanhoAsteroide;
            this.velocidadeAsteroide = velocidadeAsteroide;
            this.energiaAsteroide = energiaAsteroide;
        }

        public Asteroides (int posicaox, int posicaoy)
        {
            this.posicaox = posicaox;
            this.posicaoy = posicaoy;
        }

        /*public static void mostrarLista(List<Asteroides> lista)
        {
            foreach (Asteroides i in lista)
            {
                Console.WriteLine($" Posição X {i.Posicaox} Posição Y {i.Posicaoy} Tamanho do asteroide {i.TamanhoAsteroide} " +
         $" Velocidade do asteroide {i.VelocidadeAsteroide} Energia do asteroide {i.EnergiaAsteroide}");
            }
        }*/

        
    }
  
}
