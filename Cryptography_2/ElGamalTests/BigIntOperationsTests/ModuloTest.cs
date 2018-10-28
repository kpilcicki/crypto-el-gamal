using System;
using System.Collections.Generic;
using ElGamalImplementation;
using FluentAssertions;
using NUnit.Framework;

namespace ElGamalTests.BigIntOperationsTests
{
    public class ModuloTest
    {
        public static IEnumerable<TestCaseData> BigIntegerDivisionTestData
        {
            get
            {
                yield return new TestCaseData(
                    new BigInt(new uint[] { UInt32.MaxValue, UInt32.MaxValue, UInt32.MaxValue }),
                    new BigInt(new uint[] { UInt32.MaxValue }),
                    new BigInt(new uint[] { 0 })
                );

                yield return new TestCaseData(
                    new BigInt(new uint[] { UInt32.MaxValue }),
                    new BigInt(new uint[] { UInt32.MaxValue - 1}),
                    new BigInt(new uint[] { 1 })
                );


            }
        }

        [TestCaseSource(nameof(BigIntegerDivisionTestData))]
        public void Multiplication(BigInt first, BigInt second, BigInt expected)
        {
            var mod = first % second;

            mod.Digits.Should().BeEquivalentTo(expected.Digits);
        }
    }
}
