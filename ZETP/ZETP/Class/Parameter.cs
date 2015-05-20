using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZETP.Class
{
    class Parameter
    {
        public Type Type { get; set; }
        public string Value { get; set; }

        public Parameter(Type type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}
