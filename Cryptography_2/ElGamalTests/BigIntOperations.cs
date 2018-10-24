using System;
using ElGamalImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace ElGamalTests
{
    [TestClass]
    public class BigIntOperations
    {
        [TestMethod]
        public void AdditionTest()
        {
            BigInt first = new BigInt(new uint[3] { 1, 0, 0 });
            BigInt second = new BigInt(new uint[3] { 1, 0, 0 });

            var sum = first + second;

            sum.Words.Should().BeEquivalentTo(new uint[3] { 2, 0, 0 });
        }

    }
}