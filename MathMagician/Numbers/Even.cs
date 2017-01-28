using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Even : Integer
    {
        private int First { get; set; }

        public Even() 
        {
            First = 2;
        } 

        public int GetFirst()
        {
            return First;
        }

        public int GetNext(int current)
        {
            return current + 2;
        }

        public int[] GetSequence(int howMany)
        {
            int[] sequenceArray = new int[howMany];
            sequenceArray[0] = GetFirst(); // i = 2
            for (int i = 1; i < sequenceArray.Length; i++)
            {
                sequenceArray[i] = GetNext(sequenceArray[i - 1]);
            }

            return sequenceArray;
        }

        public string PrintNumbers(int[] evenNumArray)
        {
            return String.Join(" ", evenNumArray);
        }
    }
}
