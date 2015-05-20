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
            this.i = 1;
            this.f = 1.1f;
            this.s = "s";
        }

        public ClassForTest(int i)
        {
            this.i = i;
        }

        public ClassForTest(int i, float f, String s)
        {
            this.i = i;
            this.f = f;
            this.s = s;
        }

        public int getI() { return this.i; }

        public float getF() { return this.f; }

        public String getS() { return this.s; }
    }
}
