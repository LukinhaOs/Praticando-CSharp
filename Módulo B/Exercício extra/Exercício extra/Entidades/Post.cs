using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_extra.Entidades
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
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

        public void AddComment(Comment message)
        {
            Comments.Add(message);
        }

        public void RemoveComment(Comment message)
        {
            Comments.Remove(message);
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine(Title);
            msg.Append(Likes);
            msg.Append(" Likes - ");
            msg.AppendLine(Moment.ToString("dd/MM/yy HH:mm:ss"));
            msg.AppendLine(Content);
            msg.AppendLine("Comments:");
            foreach(Comment item in Comments)
            {
                msg.AppendLine(item.Messages);
            }
            return msg.ToString();
        }
    }
}
