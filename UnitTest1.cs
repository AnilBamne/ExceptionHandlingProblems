using ExceptionsHandlingPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MoodAnalyserTeast
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Call analyseMood function with message as parameter and return "HAPPY" or "SAD"
        /// </summary>
        /// 
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am Sad today";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyse.checkMood();
            //Assert
            Assert.AreEqual(expected, mood); 
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am Happy today";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyse.checkMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
