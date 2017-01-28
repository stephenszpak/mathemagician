using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    interface Integer
    {
        //what you should ATLEAST have, can have additional methods if needed
        //Interface are used as a GUIDE to what you should do

        int GetFirst();
        int GetNext(int current);
        int[] GetSequence(int howMany);
        string PrintNumbers(int[] howMany);
    }
}
