using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sad_Return_2_SadMood()
        {
            string St = "I am in Sad Mood";
            string required = "SAD";
            var md=new MoodAnalysers();
            string actual= md.analyseMood(St);

            Assert.AreEqual(required, actual);
        }

        [TestMethod]

        public void Happy_Return_2_HappyMsg()
        {
            string st1 = "I am Happy Today";
            string req1 = "HAPPY";

            MoodAnalysers ma = new MoodAnalysers();
            string actual1=ma.analyseMood(st1);

            Assert.AreEqual(req1, actual1);
        }

        [TestMethod]
        public void Happy_For_Normal_Text()
        {
            string str2 = "I am in Good Mood Today";
            string require = "HAPPY";
            MoodAnalysers md = new MoodAnalysers();
            string actaul1=md.analyseMood(str2);

            Assert.AreEqual(require, actaul1);

        }
    }
}