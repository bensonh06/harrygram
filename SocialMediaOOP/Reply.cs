using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaOOP
{
    internal class Reply
    {
        // private

        private DateTime _date;

        private Account _creator;

        private string _content;

        // public

        public List<Account> Likes;

        private Post _parent;

        public DateTime Date { get => _date; set => _date = value; }
        internal Account Creator { get => _creator; set => _creator = value; }
        public string Content { get => _content; set => _content = value; }

        public Reply(Post p)
        {
            _parent = p;
        }

    }
}
