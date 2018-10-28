using System;
using System.Collections.Generic;
using ElGamalImplementation;
using FluentAssertions;
using NUnit.Framework;

namespace ElGamalTests.BigIntOperationsTests
{
    public class MultiplicationTest
    {
        public static IEnumerable<TestCaseData> BigIntegerMultiplicationTestData
        {
            get
            {
                yield return new TestCaseData(
                    new BigInt(new uint[] { UInt32.MaxValue, UInt32.MaxValue, UInt32.MaxValue }),
                    new BigInt(new uint[] { 1 }),
                    new BigInt(new uint[] { UInt32.MaxValue, UInt32.MaxValue, UInt32.MaxValue })
                );

                yield return new TestCaseData(
                    new BigInt(new uint[] { 0, 0, 1 }),
                    new BigInt(new uint[] { 0, 0, 1 }),
                    new BigInt(new uint[] { 0, 0, 0, 0, 1 })
                );

                yield return new TestCaseData(
                    new BigInt(new uint[] { UInt32.MaxValue }),
                    new BigInt(new uint[] { UInt32.MaxValue }),
                    new BigInt(new uint[] { 1, UInt32.MaxValue -1 })
                );
            }
        }

        [TestCaseSource(nameof(BigIntegerMultiplicationTestData))]
        public void Multiplication(BigInt first, BigInt second, BigInt expected)
        {
            var product = first * second;

            product.Digits.Should().BeEquivalentTo(expected.Digits);
        }
    }
}
