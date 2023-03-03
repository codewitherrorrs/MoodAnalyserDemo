using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class MoodAnalyser
    {
        public void check(string mood)
        {
            if (mood == null)
            {
                throw new Exception("No Such Class Error");
            }
            /*  else if(mood == "")
              {
                  throw new Exception("No Such Method Error");
              }
            */
            else if (mood == "Happy" | mood == "happy")
            {
                Console.WriteLine("Happy");
            }
            else if (mood == "Sad" | mood == "sad")
            {
                Console.WriteLine("Sad");
            }
            else
            {
                Console.WriteLine(mood);
            }
        }
    }

   
}
