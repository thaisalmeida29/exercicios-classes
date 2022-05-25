using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
     class Animal
    {
        /// <summary>
        /// variavel que armazena o nome do animal
        /// </summary>
        
      private string nome;
        /// <summary>
        /// variavel que armazena o tipo de animal
        /// </summary>
      private string tipo;

        /// <summary>
        /// construtor para um animal com todos os atributos e variaveis
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="tipo"></param>
        public Animal (string nome, string tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        /// <summary>
        /// propriedade de acesso ao nome
        /// </summary>
        public string Nome { get => nome; set => nome = value; }

        /// <summary>
        /// propriedade de acesso ao tipo
        /// </summary>
        public string Tipo { get => tipo; set => tipo = value; }


    }
}
