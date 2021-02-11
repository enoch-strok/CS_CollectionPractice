using System;
using System.Collections.Generic;

namespace CS_CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] numArray = {1,2,3,4,6,7,8,9};
        string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};
        bool[] strArrayTF = {true, false, true, false, true, false, true, false, true, false};
        string[] strArrayFlavors = {"Vanilla", "Chocolate", "Strawberry", "Blueberry", "Blackberry"};
        
        List<string> FlavorList = new List<string>();  
        Dictionary<string,string> stuff = new Dictionary<string,string>();

        FlavorList.Add("Vanilla");  
        FlavorList.Add("Chocolate");  
        FlavorList.Add("Strawberry");  
        FlavorList.Add("Blueberry");  
        FlavorList.Add("Blackberry");

        int[] numArray2 = new int[5];
        
            for (int idx = 0; idx < numArray.Length; idx++)
                {
                    Console.WriteLine($"I own a {numArray[idx]}");
                };
            for (int idx = 0; idx < strArray.Length; idx++)
                {
                    Console.WriteLine($"my name is {strArray[idx]}");
                };
            for (int idx = 0; idx < strArrayTF.Length; idx++)
                {
                    Console.WriteLine($"{strArrayTF[idx]}");
                };
                {
                    Console.WriteLine($"Length of flavors: {strArrayFlavors.Length}");
                };
            for (int idx = 0; idx < strArrayFlavors.Length; idx++)
                {
                    Console.WriteLine($"{strArrayFlavors[idx]}");
                };
                {
                    Console.WriteLine($"3rd Flavor in List: {strArrayFlavors[2]}");
                };
            //     flavorList.Remove(2);
            // for (int idx = 0; idx < strArrayFlavors.Length; idx++)
            //     {
            //         Console.WriteLine($"{strArrayFlavors[idx]}");
            //     };
            for (var idx = 0; idx < FlavorList.Count; idx++)
                {
                    Console.WriteLine("-" + FlavorList[idx]);
                }
            Console.WriteLine($"removing {FlavorList[2]}"); 
            FlavorList.RemoveAt(2);
            for (var idx = 0; idx < FlavorList.Count; idx++)
                {
                    Console.WriteLine("-" + FlavorList[idx]);
                }

            stuff.Add("Name", "Speros");
            stuff.Add("Language", "PHP");
            stuff.Add("Location", "Greece");

            Random rand = new Random();

            for (int idx = 0; idx < strArray.Length; idx++)
                {
                    stuff.Add(strArray[idx], 
                     FlavorList[rand.Next(0,4)]
                    );
                };

            foreach (KeyValuePair<string, string> data in stuff)
                {
                    Console.WriteLine(data.Key + ":" + data.Value);
                }

                // for(int val = 0; val < 10; val++)
                // {
                //     //Prints the next random value between 2 and 8
                //     Console.WriteLine(rand.Next(1,3));
                // }
            // Console.WriteLine("From - " + stuff(0));
        }
    }
}
