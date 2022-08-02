using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            friend[] friends = new friend[] {

                new friend("Berat", 19),
                new friend("Fatih", 21)

        };

            Dictionary<string, friend> myFriends = new Dictionary<string, friend>();

            foreach(friend friend in friends)
            {

                myFriends.Add(friend.name, friend);

            }
           

                KeyValuePair<string, friend> pair = myFriends.ElementAt(0);
                Console.WriteLine(pair.Key);
            friend pairValue = pair.Value;
            Console.WriteLine(pairValue.age);

            KeyValuePair<string, friend> pair2 = myFriends.ElementAt(1);

            Console.WriteLine(pair2.Key);
            pairValue = pair2.Value;
            Console.WriteLine(pairValue.age);


        }
    }

    class friend{

        public string name { get; set; }
        public int age { get; set; }

        public friend(string name, int age) {

            this.name = name;
            this.age = age;
        }
    
    }
}
