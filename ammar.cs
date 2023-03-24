using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ammar_Hamad
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.BackgroundColor= ConsoleColor.DarkCyan;
            Console.Clear();
            

       
            Console.WriteLine("Welcom to my game");
           char[] ar = { '_', '_', '_', '_' };
            for (int i = 0; i < ar.Length; i++) {
                Console.Write(ar[i]+" ");
            }
                Console.WriteLine();
            string get = getTodayWord();


            int heart = getTodayWord().Length;
            while(heart>0)
            {
                char c = askUser(); 
                int ct =checkletter(get, c, ar);
                if (ct == -1)
                {
                    heart--;
                    Console.WriteLine("You have " + heart + " Hearts left.");
                } else
                {
                    ar [ct]  = c;
                    for (int i = 0; i < ar.Length; i++)
                    {
                        Console.Write(ar[i]+" ");
                    }
                }

                
            }

            Console.WriteLine("You lose!");

        }
        public static char askUser()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a char:");
            
            char c = Console.ReadLine()[0];
            return c;

            
        }
        public static string getTodayWord()
        {
            string[] arr = { "anaa ", "n7no", "anot", "amar", "fall", "wall", "door", "home", "neww" };
            Random random= new Random();
            int two =random.Next(1,  arr.Length);
            return arr[two];
        }
        public static int checkletter(string todayWord, char ch, char[] lines)
        {

            for (int i = 0; i < todayWord.Length; i++) {
                if (todayWord[i] == ch && lines[i] != ch) {
                    return i;

                }

            }   
            return -1; 
        }



            public static int checkWin(char[] lines) 
        {
            for (int i = 0; i < lines.Length; i++) 
            {
                if (lines[i] == '_')
                {
                    return -1;
                }
                
            }
            return 1;
            Console.WriteLine("made by amar");
        }
        

    }
}
