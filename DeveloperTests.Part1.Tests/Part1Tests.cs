using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperTests.Part1.Tests
{
    [TestClass]
    public class Part1Tests
    {
        [TestMethod]
        public void WriteFizzBuzz_CorrectStringReturned()
        {
            var expected = "";

            var result = Program.WriteFizzBuzz();

            Assert.AreEqual(expected, result);
        }
    }
}
