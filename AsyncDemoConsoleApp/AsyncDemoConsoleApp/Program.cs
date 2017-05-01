using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemoConsoleApp
{
    class Program
    {
        public delegate void PostUserData(User user);
        public static PostUserData method;
        static void Main(string[] args)
        {
            int userCount = 1;
            method = new PostUserData(PostData);
            IEnumerable<User> users = GetUsers();

            Console.WriteLine("Users signing in...");

            foreach (var user in users)
            {
                method.BeginInvoke(user, new AsyncCallback(Result), null);

                if (userCount == 4)
                {
                    Thread.Sleep(5000);
                    userCount = 0;
                }
                               
                userCount += 1;
            }



            Console.ReadKey();
        }

        private static void Result(IAsyncResult ar)
        {
            method.EndInvoke(ar);
            Console.WriteLine("");
        }

        private static IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>();
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            User user6 = new User();
            User user7 = new User();
            User user8 = new User();
            user1.username = "Vaishnav";
            user2.username = "Prathamesh";
            user3.username = "Aamod";
            user4.username = "Rucha";
            user5.username = "Samruddhi";
            user6.username = "Paritosh";
            user7.username = "Leander";
            user8.username = "Ivo";

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            users.Add(user5);
            users.Add(user6);
            users.Add(user7);
            users.Add(user8);

            return users;
        }

        //private static async void PostUserData(IEnumerable<User> users)
        //{

        //    foreach (var user in users)
        //    {
        //        await PostDataAsync(user);
        //    }

        //    Console.WriteLine("Done...");
        //}

        //private static Task PostDataAsync(User user)
        //{
        //    return Task.Run(() => PostData(user));
        //}



        private static void PostData(User user)
        {
            //Thread.Sleep(2000);
            Console.Write(user.username + " signed in successfully");

        }
    }

    public class User
    {
        //public int Id { get; set; }
        public string username { get; set; }
    }
}
