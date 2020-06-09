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
@"namespace TrProtocol
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
@"public interface INetObject
{
    void OnSerialize(BinaryWriter writer);
    void OnDeserialize(BinaryReader reader);
}";

        static void Main(string[] args)
        {
            string protocolPath;

            if (args.Length == 1)
                protocolPath = args[0];
            else
                protocolPath = Console.ReadLine();

            var loader = new TypeLoader();
            loader.Load(protocolPath);

            var codeGenerator = new CodeGenerator(
                classTemplate,
                fieldDefineTemplate);

            foreach (var type in loader.types)
            {
                var words = type.Key.Split('_');
                if (words.Length != 2)
                    continue;
                var name = "";
                if (words[0] == "type")
                    name = words[1];
                else if(int.TryParse(words[0], out var messageId))
                    name = type.Key;
                codeGenerator.Generate(name, type.Value);
            }
        }
    }
}
