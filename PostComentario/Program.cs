using PostComentario.Entities;
using System;

namespace PostComentario
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awsome!");
            Post p1 = new Post(
                DateTime.Parse("21/02/2018"),
                "Traveling",
                "Aafdsfdsfsdfs",
                12);

            p1.AddComment(c1);


            Console.WriteLine(p1);
        }
    }
}
