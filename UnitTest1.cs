using MoodAnalyserDemo;
namespace RelectionUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyser_Success()
        {
            //Arrange
            string mood = "Happy";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "Happy";

            //Act 
            string actualOutput = m1.check(mood);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}