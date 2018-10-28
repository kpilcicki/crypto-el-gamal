using System;
using System.Collections.Generic;
using ElGamalImplementation;
using FluentAssertions;
using NUnit.Framework;

namespace ElGamalTests.BigIntOperationsTests
{
    public class PowModTest
    {
        public static IEnumerable<TestCaseData> BigIntegerPowModTestData
        {
            get
            {
//                yield return new TestCaseData(
//                    new BigInt(new uint[] { UInt32.MaxValue }),
//                    new BigInt(new uint[] { UInt32.MaxValue }),
//                    new BigInt(new uint[] { 2631828 }),
//                    new BigInt(new uint[] { 499647 })
//                );
//                yield return new TestCaseData(
//                    new BigInt(new uint[] { UInt32.MaxValue }),
//                    new BigInt(new uint[] { 1234 }),
//                    new BigInt(new uint[] { 2631828 }),
//                    new BigInt(new uint[] { 515001 })
//                );
//                yield return new TestCaseData(
//                    new BigInt(new uint[] { 513 }),
//                    new BigInt(new uint[] { 4294967294 }),
//                    new BigInt(new uint[] { 2631828 }),
//                    new BigInt(new uint[] { 1996593 })
//                );

                yield return new TestCaseData(
                    new BigInt(new uint[] { UInt32.MaxValue - 7  }),
                    new BigInt(new uint[] { UInt32.MaxValue }),
                    new BigInt(new uint[] { UInt32.MaxValue }),
                    new BigInt(new uint[] { 3067833782 })
                );

            }
        }

        [TestCaseSource(nameof(BigIntegerPowModTestData))]
        public void PowMod(BigInt first, BigInt second, BigInt mod, BigInt expected)
        {
            var product = BigInt.PowMod(first, second, mod);

            product.Digits.Should().BeEquivalentTo(expected.Digits);
        }
    }
}
