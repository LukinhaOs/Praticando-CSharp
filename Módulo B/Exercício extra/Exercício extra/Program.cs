using System;
using Exercício_extra.Entidades;

namespace Exercício_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("I'm going to too. Amazing place, I hope to see many Animes in real time!");
            Comment c2 = new Comment("It's Amazing! I wait that you enjoy every time :O");
            Post p1 = new Post(
                DateTime.Parse("18/06/2022 16:27:36"),
                "Traveling to Japan! Heyyyeeyyy!",
                "I can't go now :/ But next year I'm going!",
                58);

            Comment c3 = new Comment("Stop T - T I'm hungry!");
            Comment c4 = new Comment("Poor David, I eat some cake, you should come home now!");
            Post p2 = new Post(
                DateTime.Parse("23/09/2022 19:47:50"),
                "Hello guys. How's was the dinner?",
                "Hum, Do you known I eat on the dinner? O.O Was a Delicious Fish.",
                18);

            p1.AddComment(c1);
            p1.AddComment(c2);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
