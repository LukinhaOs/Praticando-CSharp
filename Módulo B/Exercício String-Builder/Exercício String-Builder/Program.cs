using System;
using Exercício_String_Builder.Entidades;

namespace Exercício_String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario comment1 = new Comentario("Tenha uma boa viagem");
            Comentario comment2 = new Comentario("Aproveite bem. Isso será Incrível!");
            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para a Nova ZeLândia",
                "Estou indo para este lugar maravilhoso!",
                12);

            post1.AddComentario(comment1);
            post1.AddComentario(comment2);

            Comentario comment3 = new Comentario("Tenha uma boa noite gente!");
            Comentario comment4 = new Comentario("Pode ser que eu fique com vocês amanhã.");
            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Vamos todos ficar juntos amanhã de manhã!",
                "Vejo vocês amanhã então!",
                5);

            post2.AddComentario(comment3);
            post2.AddComentario(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
