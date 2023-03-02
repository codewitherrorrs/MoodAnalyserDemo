using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public void ErrorFun()
        {

            Console.WriteLine("Enter the Mood Happy or Sad: ");
            string mood = Console.ReadLine();
            try
            {
                if (mood == "Happy")
                {
                    Console.WriteLine("Happy");
                }
                else if (mood == "Sad")
                {
                    Console.WriteLine("Sad");
                }
                else if (mood == null)
                {
                    Console.WriteLine("HAPPY");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
