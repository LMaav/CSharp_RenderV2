using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRenderizador
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set;}
        public int Quantidade { get; set; }
        public string Descricao { get; set; }


        public Produto(string nome, double valor, int quantidade, string descricao)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public double calcular_estoque()
        {
            return this.Valor * this.Quantidade;
        }
    }

}
