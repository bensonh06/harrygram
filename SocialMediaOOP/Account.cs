using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaOOP
{
    internal class Account
    {
        // private

        private string _username;

        private DateTime _DOB;

        private string _email;

        private string _password;

        // public

        public string Username { get => _username; set => _username = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }

        public List<Post> Posts;

        public List<Reply> Replies;

        public List<Account> Followers;

        public void CreatePost(Account acc)
        {
            Post mypost = new Post();

            mypost.Creator = acc;

            mypost.Date = DateTime.Today;

            Console.Write("Enter the content of the post: ");

            mypost.Content = Console.ReadLine();

            Posts.Add(mypost);
        }
    }
}
