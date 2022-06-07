using System;
using System.Collections.Generic;

namespace new1
{
    public class print
    {
        
        
        public List<string> words = new List<string>() { "flower", "watch", "smile", "lion", "apple", "light" };
        public List<string> ali = new List<string>()
{@" ----------
          |
          |
          |
     __   |
  __|__|__|
",
@" -----------
      O   |
          |
          |
     __   |
  __|__|__|
",
@" -----------
      O   |
      |   |
          |
     __   |
  __|__|__|
",
@" -----------
      O   |
     /|   |
          |
     __   |
  __|__|__|
",
@" -----------
      O   |
     /|\  |
          |
     __   |
  __|__|__|
",
@" -----------
      O   |
     /|\  |
     /    |
     __   |
  __|__|__|
",
@" -----------
      O   |
     /|\  |
     / \  |
     __   |
  __|__|__|
"
};

    }
    class Program
    {
        static void Main(string[] args)
        {
            print pr = new print();
            Random rand = new Random();
            int b = rand.Next(5);
            string s = "";
            string aa = "";
            string ch = pr.words[b];
            int r = 0;
            for (int i = 0; i < 7;)
            {
                Console.Write("enter a char: ");
                string a = Console.ReadLine();
                aa += a;
                int d = 0;
                

                foreach (var item in ch)
                {

                    if (a != item.ToString())
                    {
                        s += "_ ";
                    }
                    else
                    {
                        d++;
                        s += a + " ";
                        
                    }
                }
                Console.Write("sugussed: " + aa + "\n");
                if (d==0)
                {
                        i++;
                    
                    Console.WriteLine(s);
                    s = "";
                        Console.WriteLine(pr.ali[i]);
                }
                else
                {
                    r++;
                    Console.WriteLine(s);
                    s = "";
                    Console.WriteLine(pr.ali[i]);
                }
                if (r==ch.Length)
                {
                   
                    Console.WriteLine("you win");
                    break;
                }
                if (i==6)
                {
                    Console.WriteLine("game over");
                    break;
                }
                
            }
                Console.ReadKey();
        }
    }
}

