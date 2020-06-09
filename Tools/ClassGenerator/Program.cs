using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    class Program
    {
        public const string classTemplate =
@"using System.IO;
using System;

namespace TrProtocol
{{
    /// <summary>
    /// {4}
    /// </summary>
    public class {0} : INetObject
    {{
{1}

        public void OnSerialize(BinaryWriter writer)
        {{
{2}
        }}

        public void OnDeserialize(BinaryReader reader)
        {{
{3}
        }}
    }}
}}";

        public const string fieldDefineTemplate =
@"        /// <summary>
        /// {3}
        /// </summary>
        public {0} {1} = {2};";

        public const string iNetObjectCode =
@"using System.IO;
using System;

namespace TrProtocol
{
    public interface INetObject
    {
        void OnSerialize(BinaryWriter writer);
        void OnDeserialize(BinaryReader reader);
    }
}";

        public const string enumTemplate =
@"namespace TrProtocol
{{
    /// <summary>
    /// {4}
    /// </summary>
    public enum {0}
    {{
        {1}
    }}
}}";

        public const string enumDefineTemplate =
@"        /// <summary>
        /// {3}
        /// </summary>
        {0},
";

        static void Main(string[] args)
        {
            string protocolPath;
            string output;

            if (args.Length == 2)
            {
                protocolPath = args[0];
                output = args[1];
            }
            else
            {
                protocolPath = Console.ReadLine();
                output = Console.ReadLine();
            }

            var loader = new TypeLoader();
            loader.Load(protocolPath);

            var codeGenerator = new CodeGenerator(
                classTemplate,
                fieldDefineTemplate);

            var enumCodeGenerator = new CodeGenerator(
                enumTemplate,
                enumDefineTemplate);

            foreach (var type in loader.types)
            {
                var code = "";

                var words = type.Key.Split('_');
                if (words.Length != 2)
                    continue;
                var fileName = "";
                if (words[0] == "type")
                {
                    fileName = words[1];
                    code = codeGenerator.Generate(fileName, type.Value);
                }
                else if (words[0] == "enum")
                {
                    fileName = words[1];
                    code = enumCodeGenerator.Generate(fileName, type.Value);
                }
                else if (int.TryParse(words[0], out var messageId))
                {
                    fileName = type.Key;
                    code = codeGenerator.Generate(words[1], type.Value);
                }
                code += $"\n\n//Generate at {DateTime.Now}";

                using (var outputFile = File.OpenWrite(output + "/" + fileName + ".cs"))
                using (var writer = new StreamWriter(outputFile))
                    writer.Write(code);
            }

            using (var outputFile = File.OpenWrite(output + "/INetObjectCode.cs"))
            using (var writer = new StreamWriter(outputFile))
                writer.Write(iNetObjectCode);
        }
    }
}
