using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet_Parte2.Entidades
{
    class Produto
    {
        // Essa classe por padrão não implementa os procedimentos GetHashCode e Equals

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override int GetHashCode() // Esse método faz com que o conteúdo do objeto seja igual. Caso não insira-o o programa retornará como false!
                                          // (Importante usar pois a classe por padrão não utiliza os procedimentos GetHashCode e Equals).
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object obj) // Esse método faz com que o conteúdo do objeto seja igual. Caso não insira-o o programa retornará como false!
                                                // (Importante usar pois a classe por padrão não utiliza os procedimentos GetHashCode e Equals).

        {
            if (!(obj is Produto))
            {
                return false;
            }
            Produto outro = obj as Produto;
            return Nome.Equals(outro.Nome) && Preco.Equals(outro.Preco);
        }
    }
}
