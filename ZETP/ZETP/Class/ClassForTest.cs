using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZETP
{
    public class ClassForTest
    {
        int i;
        float f;
        String s;

        public ClassForTest()
        {
            i = 1;
            f = 1.1f;
            s = "s";
        }

        public ClassForTest(int valuei)
        {
            i = valuei;
        }

        public ClassForTest(int valuei, float valuef, String values)
        {
            i = valuei;
            f = valuef;
            s = values;
        }

        public int getI() { return i; }

        public float getF() { return f; }

        public String getS() { return s; }
    }
}
