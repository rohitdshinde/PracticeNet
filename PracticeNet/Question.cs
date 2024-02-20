using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNet
{
    internal class Question
    {
       public void Q1()
        {
            ArrayList list = new ArrayList();
            list.Add("Java");
            list.Add("C#");
            list.Add("c++");

            Console.WriteLine("All languages");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

            /* string[] arr = { "java" };

             foreach (string str in arr)
             {
                 Console.WriteLine(str);
             }


              string[] str = new string[3];
             Console.WriteLine("Enetr a subject");
             for(int i = 0; i < str.Length; i++)
             {
                 str[i] = Console.ReadLine();
             }

             for(int i = 0;i < str.Length; i++)
             {
                 Console.WriteLine(str[i]);
             }


              string[] str = new string[3];
            Console.WriteLine("Enetr a subject");
            for(int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            for(int i=str.Length-1;i>=0; i--)
            {
                Console.WriteLine(str[i]);
            }
           
             */


        }
       public void Q2()
        {
            Console.WriteLine("Enter the size of an array");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] Number = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Numbers {i + 1}");
                Number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largerst = Number[0];
            int lowest = Number[0];

            foreach (int num in Number)
            {
                if (num > largerst)
                {
                    largerst = num;
                }
                if (num < lowest)
                {
                    lowest = num;
                }
            }
            Console.WriteLine($"Largest number{largerst}");
            Console.WriteLine($"lowest number{lowest}");
        }
        public void Q3()
        {
            Console.WriteLine("Enter a string");
            string strr = Console.ReadLine();

            string[] words = strr.Split(' ');

            Console.WriteLine("Reverse a string:");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i] + "");
            }
            Console.ReadLine();


        }
       
    }
}