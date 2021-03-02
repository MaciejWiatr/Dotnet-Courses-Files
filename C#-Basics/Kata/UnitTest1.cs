using NUnit.Framework;
using System.Collections.Generic;

namespace Kata
{
    public class Tests
    {
        [Test]
        public void SplitTests()
        {
            var testString = "this is a test";
            var result = Kata.Split(testString, ' ');

            Assert.AreEqual("test", result[3]);
            Assert.AreEqual("a", result[2]);
            Assert.AreEqual("is", result[1]);
            Assert.AreEqual("this", result[0]);
        }

        [Test]
        public void ReverseTest()
        {
            var testList = new List<string>() { "this", "is", "a", "test" };
            var result = Kata.Reverse(testList);

            Assert.AreEqual(result[0], "test");
            Assert.AreEqual(result[1], "a");
            Assert.AreEqual(result[2], "is");
            Assert.AreEqual(result[3], "this");
        }

        [Test]
        public void JoinTest()
        {
            var testList = new List<string>() { "this", "is", "a", "test" };
            var result = Kata.Join(testList, ' ');
            Assert.AreEqual(result, "this is a test");
        }


        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
        }

    }
}
