using System.Dynamic;
using System.Reflection;

namespace MoodAnalyserDemo
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the mood : ");
            string mood = Console.ReadLine();
            try
            {
                  MoodAnalyser m1 = new MoodAnalyser();
                  m1.check(mood);
            }
              catch(Exception e) 
            {
                  Console.WriteLine(e.Message);
            } 

        }

    }
}