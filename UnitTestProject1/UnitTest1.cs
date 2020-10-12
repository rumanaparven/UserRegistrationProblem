using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "HAPPY";
            string message = "I am HAPPY";
            Validation validation = new Validation();
            string actual=validation.MoodAnalyser(message);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "HAPPY";
            string message = "I am SAD";
            Validation validation = new Validation();
            string actual = validation.MoodAnalyser(message);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("rumana@gmail.com")]
        [DataRow("r12@gmail.com")]
        [DataRow("rumana@gmail")]
        public void TestMethod3(string email)
        {
            bool expected = true;
            Validation validation = new Validation();
            bool actual = validation.EmailIDValidation(email);
            Assert.AreEqual(expected, actual);

        }
    }
}
