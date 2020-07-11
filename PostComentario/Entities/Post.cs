using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;

namespace PostComentario.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        List<Comment> Comments { get; set; } = new List<Comment>();


        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.AppendLine(Content);
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
