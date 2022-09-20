using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_extra.Entidades
{
    class Comment
    {
        public string Messages {get; set;}

        public Comment()
        {

        }

        public Comment(string message)
        {
            Messages = message;
        }
    }
}
