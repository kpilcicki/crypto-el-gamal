//using System;
//using System.Collections.Generic;
//using ElGamalImplementation;
//using FluentAssertions;
//using NUnit.Framework;
//
//namespace ElGamalTests.ExtensionsTests
//{
//    public class DoubleWordsArrayExtensionsTests
//    {
//        public static IEnumerable<TestCaseData> GetBitTestData
//        {
//            get
//            {
//                yield return new TestCaseData(
//                    new uint[] {0, 32},
//                    37, 
//                    true
//                );
//
//                yield return new TestCaseData(
//                    new uint[] { 0, 0, UInt32.MaxValue - 512},
//                    73,
//                    false
//                );
//            }
//        }
//
//
//        [TestCaseSource(nameof(GetBitTestData))]
//        public void GetBitTests(uint[] dWordsArray, int bitNumber, bool expectedResult)
//        {
//            dWordsArray.GetBit(bitNumber).Should().Be(expectedResult);
//        }
//    }
//}
