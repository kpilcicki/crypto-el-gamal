using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElGamalImplementation
{
    class BigInt
    {
        public static uint MAX_DIGIT = UInt32.MaxValue;

        public uint[] Words { get; private set; }

        public int Length { get => Words.Length; }

        public uint this[int i]
        {
            get => Words[i];
            private set => Words[i] = value;
        }

        public BigInt(uint[] words)
        {
            Words = words;
        }

        public static BigInt PowMod(BigInt stand, BigInt exponent, BigInt modulus)
        {
            return null; // (stand ^ exponent) % modulus;
        }

        public static BigInt operator *(BigInt self, BigInt other)
        {
            return null;
        }

        public static BigInt operator%(BigInt self, BigInt other)
        {
            return null;
        }

        public static BigInt operator +(BigInt self, BigInt other)
        {
            BigInt bigger, smaller;
            if (self > other)
            {
                bigger = self;
                smaller = other;
            }
            else
            {
                bigger = other;
                smaller = self;
            }

            List<uint> result = bigger.Words.ToList();
            bool carry = false;

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = unchecked(bigger[i] + smaller[i] + (uint)(carry ? 1 : 0));

                bool didSmallerOverflow = smaller[i] == MAX_DIGIT && (bigger[i] != 0 || carry);
                bool regularOverflowHappened = (MAX_DIGIT - result[i]) <= (carry ? smaller[i] + 1 : smaller[i]);

                if (didSmallerOverflow || regularOverflowHappened) carry = true;
                else carry = false;

            }
            if (carry) result.Add(1);

            return new BigInt(result.ToArray());
        }

        #region COMPARISON_OPERATORS
        public static bool operator <(BigInt self, BigInt other)
        {
            var areEqual = self.Length == other.Length;
            return areEqual ? self[0] < other[0] : self.Length < other.Length;
        }

        public static bool operator >(BigInt self, BigInt other)
        {
            var areEqual = self.Length == other.Length;
            return areEqual ? self[0] > other[0] : self.Length > other.Length;
        }

        public static bool operator <=(BigInt self, BigInt other)
        {
            return !(self > other);
        }

        public static bool operator >=(BigInt self, BigInt other)
        {
            return !(self < other);
        }
        #endregion
    }
}
