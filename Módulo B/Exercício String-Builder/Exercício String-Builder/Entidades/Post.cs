using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_String_Builder.Entidades
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {

        }

        public Post(DateTime momento, string titulo, string conteudo, int like)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = like;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder com = new StringBuilder();
            com.AppendLine(Titulo);
            com.Append(Likes);
            com.Append(" Likes - ");
            com.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            com.AppendLine(Conteudo);
            com.AppendLine("Comentários:");
            foreach(Comentario item in Comentarios)
            {
                com.AppendLine(item.Mensagem);
            }
            return com.ToString();
        }
    }
}
