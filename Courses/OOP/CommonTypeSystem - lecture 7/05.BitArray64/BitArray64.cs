using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        private int[] bitArray = new int[64];

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        

        //constructor
        public BitArray64(ulong number)
        {
            this.Number = number;
            // fills array with bits of the number
            for (int i = 0; i < 64; i++)
            {
                bitArray[i] = (int)(number % 2);
                number /= 2;
            }
        }

        // implement foreach
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.bitArray[i];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;

            if ((object)bitArray == null)
            {
                return false;
            }

            if (Object.Equals(this.number, bitArray.number))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        //indexator
        private bool IndexChecker(int index)
        {
            if (index < 0 || index > 63)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //index to check the bit at position
        public int this[int key]
        {
            get { return this.bitArray[key]; }
            set
            {
                if (value == 1 || value == 0)
                {
                    this.bitArray[key] = value;
                    ChangeNumber();
                }
                else
                {
                    throw new ArgumentException("Bits could be with value only 0 or 1.");
                }
            }
        }

        // this method changes the original number after change of a bit
        private void ChangeNumber()
        {
            this.Number = 0;
            // calculate the new number
            for (int i = 0; i < 64; i++)
            {
                this.Number += (ulong)(this.bitArray[i] << i);
            }
        }

        public static bool operator ==(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return BitArray64.Equals(firstBitArray, secondBitArray);
        }

        public static bool operator !=(BitArray64 firstBitArray, BitArray64 secondBitArray)
        {
            return !BitArray64.Equals(firstBitArray, secondBitArray);
        }
    }
}