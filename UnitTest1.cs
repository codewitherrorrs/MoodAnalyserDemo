using MoodAnalyserDemo;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mood_Success()
        {
            //Arrange
            string h = "Happy";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "HAPPY";

            //Act 
            string actualOutput = m1.Mood(h);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);


        }
    }
}