using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class NaturalNumber : Integer
    {
        //private makes it where you can't access outside of the class
        private int First { get; set; }

        //constructors do not have return types and have to be public
        public NaturalNumber()
        {
            this.First = 1;
        } 

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            current = current + 1;
            return current;
        }

        public int[] GetSequence(int howMany)
        {
            int[] sequenceArray = new int[howMany];

            for (int i = 0; i < sequenceArray.Length; i++)
            {
                sequenceArray[i] = i + i;
            }
            return sequenceArray;
        }

        public string PrintNumbers(int[] howMany)
        {
            throw new NotImplementedException();
        }
    }
}
