using ClassGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGenerator
{
    public class CodeGenerator
    {
        private string _argTemplate;
        private string _headTemplate;

        public CodeGenerator(string argTemplate, string headTemplate)
        {
            _argTemplate = argTemplate;
            _headTemplate = headTemplate;
        }

        public string Generate(string name, TypeInfo typeInfo)
        {
            var argsCode = "";
            foreach (var arg in typeInfo.args)
            {
                var argCode = string.Format(_argTemplate, arg.name, arg.type, arg.desc);

                if (!string.IsNullOrEmpty(argsCode))
                    argsCode += "\n";
                argsCode += argCode;
            }

            var code = string.Format(_headTemplate, name, argsCode);

            return code;
        }
    }
}
