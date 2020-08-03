using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        //3 basic arrays
        public static void array1()
        {
            //Create an array to hold integer values 0 through 9
            int[] array1 = new int[] 
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            Console.WriteLine(String.Join(", ", array1));
        }
        //Create an array of names
        public static string[] array2() 
        {
            string[] names = new string[]
            {
                "Makenna",
                "Cory",
                "Dany",
                "Oscar",
                "Natasha",
                "Ben",
                "Lida",
                "Kira",
                "Jordan"

            };
            Console.WriteLine(String.Join(", ", names));
            return names;

        }
        static void array3()
        {
            bool[] array3 = new bool[]
            {
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false
            };
            Console.WriteLine(String.Join(", ", array3));
        }
        //list of flavors
        public static List<string> flavors()
        {
            //Create a list of ice cream flavors that holds at least 5 different flavors
            List<string> flavorslist = new List<string> ();
            flavorslist.Add("Rocky Road");
            flavorslist.Add("Rainbow Sherbert");
            flavorslist.Add("Cherry Garcia");
            flavorslist.Add("Half Baked");
            flavorslist.Add("Vanilla Bean");
            flavorslist.Add("Strawberry");
            flavorslist.Add("Caramel Crunch");
            flavorslist.Add("Chunky Monkey");
            flavorslist.Add("Phish Food");
            Console.WriteLine(String.Join(", ", flavorslist));
            //Output the length of this list after building it
            Console.WriteLine(flavorslist.Count);
            //Output the third flavor in the list, then remove this value
            Console.WriteLine(flavorslist[2]);
            flavorslist.RemoveAt(2);
            Console.WriteLine(flavorslist.Count);
            return flavorslist;
        }
        //user info dictionary
        public static void userinfo(List<string> flavorslist, string[] names)
        {
            //Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> user = new Dictionary<string, string> ();
            //Add key/value pairs to this dictionary where:
            //each key is a name from your names array
            //each value is a randomly select a flavor from your flavors list.
            foreach( string name in names)
            {
                user.Add(name, null);
            }
            Random rand = new Random();
            foreach(string name in names)
            {
                int x = rand.Next(flavorslist.Count-1);
                user[name] = flavorslist[x];
            }
            //Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(var entry in user)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}!", entry.Key, entry.Value);
            }
        }
        static void Main(string[] args)
        {
            array1();
            array2();
            array3();
            flavors();
            userinfo(flavors(), array2());

        }
    }
}
