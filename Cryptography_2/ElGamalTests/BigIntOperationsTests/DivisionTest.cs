using System;
using System.Collections.Generic;
using ElGamalImplementation;
using FluentAssertions;
using NUnit.Framework;

namespace ElGamalTests.BigIntOperationsTests
{
    public class DivisionTest
    {
        public static IEnumerable<TestCaseData> BigIntegerDivisionTestData
        {
            get
            {
                yield return new TestCaseData(
                    new BigInt(new uint[] { 538445825 , 16}),
                    new BigInt(new uint[] { 2631828 }),
                    new BigInt(new uint[] { 26315 }),
                    new BigInt(new uint[] { 1368741 })
                );
            }
        }

        [TestCaseSource(nameof(BigIntegerDivisionTestData))]
        public void Division(BigInt first, BigInt second, BigInt expectedQuation, BigInt expectedRemainder)
        {
            var quotient = BigInt.Divide(first, second, out BigInt remainder);

            quotient.Digits.Should().BeEquivalentTo(expectedQuation.Digits);
            remainder.Digits.Should().BeEquivalentTo(expectedRemainder.Digits);
        }
    }
}
