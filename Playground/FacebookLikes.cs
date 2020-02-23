using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class FacebookLikes
    {
        public static void Run()
        {
            List<string> friends = new List<string>();
            string name;
            Console.WriteLine(@"Please enter a name of the person that liked the post.");
            Console.WriteLine(@"If no one liked the post yet press enter to finish.");
            while ((name = Console.ReadLine()) != "")
            {
                friends.Add(name);
                Console.WriteLine(@"Please enter a name of the person that liked the post.");
                Console.WriteLine(@"If no one else liked the post press enter to show the result and finish.");
            }
            switch (friends.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(string.Format("{0} likes your post."
                                                    , friends[0]));
                    break;
                case 2:
                    Console.WriteLine(string.Format("{0} and {1} like your post."
                                                    , friends[0]
                                                    , friends[1]));
                    break;
                default:
                    Console.WriteLine(string.Format("{0}, {1} and {2} others like your post."
                                                    , friends[0]
                                                    , friends[1]
                                                    , friends.Count - 2));
                    break;
            }
            Console.WriteLine();
        }

    }
}
