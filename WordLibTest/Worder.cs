using WordLib;

namespace WordLibTest
{
    [TestClass]
    public class Worder
    {
        [TestMethod]
        public void IsPalindrome()
        {
            Words words = new Words();
            var input = words.Palindrome("mostafa");
            var result = "afatsom";
            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void countletters()
        {
            Words words = new Words();

            var input = words.CountLetters("mostafa");
            var result = 7;
            Assert.AreEqual(input, result);
        }
    }
}