using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

            //string[] words = strr.Split(' ');

            Console.WriteLine("Reverse a string:");
            for (int i = strr.Length - 1; i >= 0; i--)
            {
                Console.Write(strr[i] + "");
            }
            Console.ReadLine();


        }
        public void Q4()
        {
            Console.WriteLine("Enter a string");
            string strr = Console.ReadLine(); 

            char[] str1 = strr.ToCharArray();// "rohit" => ['r', 'o', 'h', ,'i', 't'] 
            Array.Reverse(str1);
            Console.WriteLine(str1);



        }
        public void Q5()
        {
            Console.WriteLine("Enter number of rows and columns of the matrix");
            int m=Convert.ToInt32(Console.ReadLine());
            int n=Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[m, n];
            Console.WriteLine("Enter the First matrix");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    A[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i,j]+"\t");
                }
                Console.WriteLine();
            }
            int[,] B = new int[m, n];
            Console.WriteLine("Enter the Second matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Second matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(B[i, j]+"\t");
                }
                Console.WriteLine();
            }
            int[,]c= new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.WriteLine("Matrix Addition");
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
      
            

    }
}