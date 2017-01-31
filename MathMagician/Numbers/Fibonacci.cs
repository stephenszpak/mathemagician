using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class Fibonacci : NaturalNumber
    {
        public override int[] GetSequence(int howMany)
        {
            int[] fibSequence = new int[howMany];
            fibSequence[0] = GetFirst();
            if (howMany >= 2)
            {
                fibSequence[1] = 1;
            }
            for (int i = 2; i < howMany; i++)
            {
                fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
            }
            return fibSequence;
        }
    }
}
