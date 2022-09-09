using Microsoft.VisualStudio.TestTools.UnitTesting;
using RT2.FizzBuzz;
using System;
using System.Collections.Generic;

namespace Rt2.FuzzBuzz.Test
{
    [TestClass]
    public class FuzzBuzzTest
    {
        private Dictionary<int, string> _defaultMappings = new Dictionary<int, string>()
        {
            {3,"fizz" },
            {5,"buzz" }
        };

        [TestMethod]
        public void TestEqual15()
        {
            var output = FizzBuzzTool.Evaluate(16, _defaultMappings);

            var number15 = output[15];
            
            Assert.AreEqual(number15.IsMatch, true);
            
            foreach (var item in number15.MatchedNumbers)
            {
                Assert.IsTrue(item == 3 || item == 5);
            }
        }

        [TestMethod]
        public void TestWithCustomMapping()
        {
            var output = FizzBuzzTool.Evaluate(13, new Dictionary<int, string>()
            {
                {2, "fizz"},
                {4,"buzz"  },
                {6, "ozz" }
            });

            var number12 = output[12];

            Assert.AreEqual(number12.IsMatch, true);

            foreach (var item in number12.MatchedNumbers)
            {
                Assert.IsTrue(item == 2 || item == 4 || item == 6);
            }
        }

        [TestMethod]
        public void TestLessThanOneOnEvaluate()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FizzBuzzTool.Evaluate(0, _defaultMappings));
        }

        [TestMethod]
        public void TestWithoutMapping()
        {
            Assert.ThrowsException<ArgumentException>(() => FizzBuzzTool.Evaluate(100, null));
        }

        [TestMethod]
        public void TestBiggerThanMax()
        {
            var output = FizzBuzzTool.Evaluate(100, _defaultMappings);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => output[101]);
        }

        [TestMethod]
        public void TestLessThanOneOnOutput()
        {
            var output = FizzBuzzTool.Evaluate(100, _defaultMappings);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => output[0]);
        }
    }
}
