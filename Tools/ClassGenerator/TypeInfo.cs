using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    public class TypeInfo
    {
        public string desc;
        public bool c2s;
        public bool s2c;
        public TypeField[] args;

        public string serialization;
        public string deserialization;

        public string[] functions;
    }
}
