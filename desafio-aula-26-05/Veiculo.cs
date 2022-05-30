using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioaula2605
{
    class Veiculo
    {
        string placa;
        DateTime datahoraEntrada;

        private void gerarDataHoraEntrada()
        {
            this.datahoraEntrada = DateTime.Now;
            //this.datahoraEntrada = this.datahoraEntrada.ToString();
        }

        
        public Veiculo(string placa)
        {
            this.placa = placa;
            this.gerarDataHoraEntrada();
        }

       
        public Veiculo(string placa, DateTime datahoraEntrada)
        {
            this.placa = placa;
            this.datahoraEntrada = datahoraEntrada;
        }

        public string Placa { get => placa; set => placa = value; }

        public DateTime DataHoraEntrada { get => datahoraEntrada; }
    }
}