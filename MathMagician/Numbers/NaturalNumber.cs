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
        protected int First { get; set; }
        protected int Step { get; set; }

        //constructors do not have return types and have to be public
        public NaturalNumber()
        {
            First = 1;
            Step = 1;
        } 

        public int GetFirst()
        {
            return First;
        }

        public virtual int GetNext(int current)
        {
            //'current' argument is read-only
        
            return current + Step;
        }

        public virtual int[] GetSequence(int howMany)
        {
            int[] sequenceArray = new int[howMany];
            sequenceArray[0] = GetFirst(); // i = 1
            for (int i = 1; i < sequenceArray.Length; i++)
            {
                sequenceArray[i] = GetNext(sequenceArray[i - 1]);
            }
            
            return sequenceArray;
        }

        public string PrintNumbers(int[] numberArray)
        {
            return String.Join(" ", numberArray);
        }
    }
}
