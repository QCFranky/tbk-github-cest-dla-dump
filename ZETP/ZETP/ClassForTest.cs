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

        public ClassForTest(int i = 0, float f = 0.0f, String s = "")
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
