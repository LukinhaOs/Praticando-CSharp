using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Produtocap
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produtocap(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double ValorTotEmEstoque()
        {
            return _preco * _quantidade;
        }

        public Produtocap()
        {
            _quantidade = 10;
        }
        public Produtocap(string nome, double preco) : this() // POR AQUI ESTÁ SENDO REAPROVEITADO O CONSTRUTUOR ACIMA QUE POSSUI QUANTIDADE = 10
        {
            _nome = nome;
            _preco = preco;
            // É POSSIVEL DE NÃO INSERIR ESSA VARIÁVEL, FUNCIONARÁ DA MESMA FORMA VALENDO 0!
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$"
                + ValorTotEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
}
