using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{

    internal class Program
    {
      static void Main(string[] args) 
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;               // when interating through a loop, the value of "i" increments sequentilly, so it will be 0 -> 0, 1 -> 1, 2 -> 2, and so forth until 9.
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} - {1}", j, nums[j]);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");


            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} - {1}", counter++, k);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            string[] friends = new string[5];
            friends[0] = "My Family";
            friends[1] = "Alex Zenin";
            friends[2] = "Boychuk";
            friends[3] = "Pervak";
            friends[4] = "Myself";
            foreach (string friend in friends)
            {
                Console.WriteLine($"Hello, {friend}!");
            }
        }
    }
}