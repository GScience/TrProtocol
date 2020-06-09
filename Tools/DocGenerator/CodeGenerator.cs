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

        private string GenerateCodeBox(string code)
        {
            return
$@"```csharp
{code}
```
";
        }
        public string Generate(string name, TypeInfo typeInfo)
        {
            var argsCode = "";
            foreach (var arg in typeInfo.args)
            {
                var argCode = string.Format(_argTemplate, arg.name, $"[{arg.type}](#Type {arg.type})", string.IsNullOrEmpty(arg.desc) ? "-" : arg.desc);

                if (!string.IsNullOrEmpty(argsCode))
                    argsCode += "\n";
                argsCode += argCode;
            }

            if (!string.IsNullOrEmpty(typeInfo.serialization) && !string.IsNullOrEmpty(typeInfo.deserialization))
            {
                var serializationCode = typeInfo.serialization;
                var deserializationCode = typeInfo.deserialization;
                return
                    string.Format(
                        _headTemplate,
                        name,
                        argsCode,
                        "Serialization: \n" + GenerateCodeBox(serializationCode) + "Deserialization: \n" + GenerateCodeBox(deserializationCode) + "\n");
            }
            return string.Format(_headTemplate, name, argsCode, "Using default serialization method");
        }
    }
}
