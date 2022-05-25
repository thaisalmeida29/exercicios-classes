using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula2505
{
    internal class Livro
    {
        /// <summary>
        /// atributos
        /// </summary>
        public string titulo;
        public string autor;
        public int paginas;
        public int ano;
        public int edicao;

        /// <summary>
        /// metodo construtor
        /// </summary>
        /// <param name="tit"></param>
        /// <param name="au"></param>
        /// <param name="pag"></param>
        /// <param name="an"></param>
        /// <param name="ed"></param>
        public Livro(string tit, string au, int pag, int an, int ed)
        {
            titulo = tit;
            autor = au;
            paginas = pag;
            ano = an;
            edicao = ed;
        }

        /// <summary>
        /// metodos
        /// </summary>
        public void apresentarInfoLivro()
        {
            Console.WriteLine("O livro com titulo de " + titulo + " do autor " + autor + " edição " + edicao + " lançado no ano de " + ano + " com " + paginas + " páginas");
        }

    }
}
