using System;
using System.Drawing;
using System.Numerics;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            //string[,] mass = new string[6, 7];

            //List<string> myList = new List<string>()
            //{
            //    "A_Red",
            //    "B_Yellow",
            //    "A_Red",
            //    "B_Yellow",
            //    "A_Red",
            //    "B_Yellow",
            //    "G_Red",
            //    "B_Yellow"
            //};

            ///// A B C D E F G 
            ///// Yeellow = 1 / Red = 2

            //Queue<string> A = new Queue<string>();
            //Queue<string> B = new Queue<string>();
            //Queue<string> C = new Queue<string>();
            //Queue<string> D = new Queue<string>();
            //Queue<string> E = new Queue<string>();
            //Queue<string> F = new Queue<string>();
            //Queue<string> G = new Queue<string>();

            //for (int i = 0; i < myList.Count; i++)
            //{
            //    if (myList[i].Contains("A_") == true)
            //        A.Enqueue(myList[i]);
            //    else if (myList[i].Contains("B_") == true)
            //        B.Enqueue(myList[i]);
            //    else if (myList[i].Contains("C_") == true)
            //        C.Enqueue(myList[i]);

            //}


            long num = 9000000;

            char[] kek = num.ToString().ToCharArray();

            string line = "";

            string lol(int i, int k)
            {
                string zxc = "";
                for ( int x=0; x < k-i-1; x++)
                {
                    zxc += "0";
                }
                return zxc;
            }

            for ( int i = 0; i < kek.Length; i++)
            {
                if (i == kek.Length - 1)
                {
                    line += kek[i];
                    break;
                }    
                if (kek[i] != '0')
                    line += kek[i] + lol(i, kek.Length) + " + ";
            }

            Console.WriteLine(line);


            Console.ReadLine();


        }
    }
}
