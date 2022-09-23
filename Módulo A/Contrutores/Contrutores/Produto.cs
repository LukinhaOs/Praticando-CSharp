using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Contrutores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        } 

        public double ValorTotEmEstoque()
        {
            return Preco * Quantidade;
        }

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco) : this() // POR AQUI ESTÁ SENDO REAPROVEITADO O CONSTRUTUOR ACIMA QUE POSSUI QUANTIDADE = 10
        {
            Nome = nome;
            Preco = preco;
            // É POSSIVEL DE NÃO INSERIR ESSA VARIÁVEL, FUNCIONARÁ DA MESMA FORMA VALENDO 0!
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$"
                + ValorTotEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
