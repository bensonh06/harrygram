using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaOOP
{
    internal class SocialMedia
    {

        public List<Account> Accounts;

        public void ViewAccounts()
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                Console.WriteLine("\nUsername: " + Accounts[i].Username);
                Console.WriteLine("Date of Birth: " + Accounts[i].Username);
                Console.WriteLine("Email: " + Accounts[i].Username);
                Console.WriteLine("Followers: " + Accounts[i].Followers.Count);
                Console.WriteLine("Posts: " + Accounts[i].Posts.Count);
            }
        }

        public bool CheckUsername(string n)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Username == n)
                {
                    return true;
                }
            }

            return false;
        }

        public void CreateAccount()
        {
            while (true)
            {
                Console.Write("Enter Username: ");
                string user = Console.ReadLine();

                if (!CheckUsername(user))
                {
                    break;
                }
                Console.WriteLine("Username Taken.");
            }

            Console.Write("Enter DOB: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Email: ");
            string mail = Console.ReadLine();
        }

        public SocialMedia()
        {
            Accounts = new List<Account>();
        }

    }
}
