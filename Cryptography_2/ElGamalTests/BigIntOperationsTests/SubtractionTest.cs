using System;
using System.Collections.Generic;
using ElGamalImplementation;
using FluentAssertions;
using NUnit.Framework;

namespace ElGamalTests.BigIntOperationsTests
{
    public class SubtractionTest
    {
        public static IEnumerable<TestCaseData> BigIntegerSubtractionTestData
        {
            get
            {
                yield return new TestCaseData(
                    new BigInt(new uint[] { 2, UInt32.MaxValue, UInt32.MaxValue }),
                    new BigInt(new uint[] { 3 }),
                    new BigInt(new uint[] { UInt32.MaxValue, UInt32.MaxValue - 1, UInt32.MaxValue })
                );

                yield return new TestCaseData(
                    new BigInt(new uint[] { 2, UInt32.MaxValue, UInt32.MaxValue }),
                    new BigInt(new uint[] { 3, UInt32.MaxValue }),
                    new BigInt(new uint[] { UInt32.MaxValue, UInt32.MaxValue, UInt32.MaxValue - 1 })
                );


            }
        }

        [TestCaseSource(nameof(BigIntegerSubtractionTestData))]
        public void Subtraction(BigInt first, BigInt second, BigInt expected)
        {

            var diff = first - second;
            diff.Digits.Should().BeEquivalentTo(expected.Digits);
        }
    }
}
