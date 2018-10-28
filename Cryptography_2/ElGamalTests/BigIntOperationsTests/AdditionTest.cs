using System;
using System.Collections.Generic;
using ElGamalImplementation;
using FluentAssertions;
using NUnit.Framework;

namespace ElGamalTests.BigIntOperationsTests
{
    public class AdditionTest
    {
        public static IEnumerable<TestCaseData> BigIntegerAdditionTestData
        {
            get
            {
                yield return new TestCaseData(
                    new BigInt(new uint[] { UInt32.MaxValue, UInt32.MaxValue, UInt32.MaxValue }),
                    new BigInt(new uint[] { 1 }),
                    new BigInt(new uint[] { 0, 0, 0, 1 })
                );

                yield return new TestCaseData(
                    new BigInt(new uint[] { 0, 0, 1 }),
                    new BigInt(new uint[] { 1, 1, 3 }),
                    new BigInt(new uint[] { 1, 1, 4 })  
                );
            }
        }

        [TestCaseSource(nameof(BigIntegerAdditionTestData))]
        public void Addition(BigInt first, BigInt second, BigInt expected)
        {
            var sum = first + second;
            sum.Digits.Should().BeEquivalentTo(expected.Digits);
        }
    }
}
