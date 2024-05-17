using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaOOP
{
    internal class Post
    {

        // private

        private DateTime _date;

        private Account _creator;

        private string _content;

        // public

        public List<Account> Likes;

        public List<Reply> Replies;

        public DateTime Date { get => _date; set => _date = value; }
        internal Account Creator { get => _creator; set => _creator = value; }
        public string Content { get => _content; set => _content = value; }

        public void CreateReply(Account acc)
        {
            Reply myreply = new Reply(this);

            myreply.Date = DateTime.Today;
            myreply.Creator = acc;

            Console.Write("Enter the content of the post: ");

            myreply.Content = Console.ReadLine();

            Replies.Add(myreply);
        }

    }
}
