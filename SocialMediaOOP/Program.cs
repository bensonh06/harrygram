using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocialMediaOOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "harrygram";

            SocialMedia social = new SocialMedia();

            Account loggedInto = null;

            while (true)
            {

                if (loggedInto != null)
                {

                }

                Console.Write(" [1] Sign Up\n [2] Log In\n\nChoose an option (1/2): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Account yes = SignUp(social);
                        social.Accounts.Add(yes);
                        loggedInto = yes;
                        break;

                    case "2":
                        
                        Account yep = LogIn(social);
                        if (!(yep == null))
                            loggedInto = yep;
                        break;

                    default:
                        break;
                }

                Console.Clear();
            }
            
        }

        static void MainMenu(SocialMedia s, Account session)
        {
            Console.Clear();
            Console.WriteLine("Hello, " + session.Username + "!\n");
            Console.WriteLine("Choose an option: \n [1] View recent posts\n [2] Create a post\n [3] View all accounts\n ");
        }

        static Account LogIn(SocialMedia s)
        {
            Console.Clear();

            Console.Write("Enter a username: ");

            string user = Console.ReadLine();

            Console.Write("Enter a password: ");

            string pass = Console.ReadLine();

            foreach(Account i in s.Accounts)
            {
                if (i.Username == user)
                {
                    if (i.Password == pass)
                    {
                        return i;
                    }
                }
            }

            Console.WriteLine("\nInvalid login. Returning to main menu..");

            Thread.Sleep(3000);

            return null;
        }

        static Account SignUp(SocialMedia s)
        {
            Console.Clear();

            Account newacc = new Account();

            while (true)
            {
                Console.Write("Enter a username: ");

                string name = Console.ReadLine();

                if (s.CheckUsername(name))
                {
                    Console.WriteLine("Username taken. Try again.");
                }
                else
                {
                    newacc.Username = name;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Enter a password: ");

                string pass = Console.ReadLine();

                if (pass.Length > 0)
                {
                    newacc.Password = pass;
                    break;
                } else
                {
                    Console.WriteLine("bad password. Try again.");
                }
            }

            while (true)
            {
                Console.Write("Enter your DOB: ");

                string date = Console.ReadLine();

                DateTime DOB;

                try
                {
                    DOB = DateTime.Parse(date);
                    newacc.DOB = DOB;
                    break;
                } 
                catch
                {
                    continue;
                }
            }

            while (true)
            {
                Console.Write("Enter your email: ");

                string mail = Console.ReadLine();

                if (!mail.Contains("@"))
                {
                    Console.WriteLine("Not an email. Try again.");
                }
                else
                {
                    newacc.Email = mail;
                    break;
                }
            }

            return newacc;
        }
    }
}
