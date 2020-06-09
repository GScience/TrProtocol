using ClassGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocGenerator
{
    class Program
    {
        public const string enumTemplate =
@"| {1} | {2} |";

        public const string enumHeadTemplate =
@"#### {0}

| value | description |
| ----- | ----- |
{1}
";

        public const string argTemplate =
@"| {0} | {1} | {2} |";

        public const string messageTemplate =
@"#### {0}

{3}

| arg | type | description |
| ----- | ----- | ----- |
{1}

{2}";

        public const string typeTemplate =
@"#### {0}

| field | type | description |
| ----- | ----- | ----- |
{1}

{2}";

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

            var msgCodeGenerator = new CodeGenerator(argTemplate, messageTemplate);
            var typeCodeGenerator = new CodeGenerator(argTemplate, typeTemplate);
            var enumCodeGenerator = new CodeGenerator(enumTemplate, enumHeadTemplate);
            var docCode = "## Terraria protocol\n";

            var typeList = loader.types.ToList();
            typeList.Sort((pair1, pair2) => string.Compare(pair1.Key, pair2.Key));

            var beginEnum = false;
            var beginType = false;

            foreach (var type in typeList)
            {
                var words = type.Key.Split('_');

                if (words.Length != 2)
                    continue;
                var name = "";
                if (words[0] == "type")
                {
                    name = words[1];
                    if (!beginType)
                        docCode += "### Inner type definations\n";
                    beginType = true;
                }
                else if (words[0] == "enum")
                {
                    name = words[1];
                    if (!beginEnum)
                        docCode += "### Inner enum definations\n";
                    beginEnum = true;
                }
                else if (int.TryParse(words[0], out var messageId))
                    name = type.Key;
                else
                    continue;

                if (beginType)
                    docCode += typeCodeGenerator.Generate(name, type.Value);
                else if (beginEnum)
                    docCode += enumCodeGenerator.Generate(words[1], type.Value);
                else
                    docCode += msgCodeGenerator.Generate($"[{words[0]}]{words[1]}", type.Value);
                
                docCode += "\n";
            }

            docCode +=
$@"----
Generate at {DateTime.Now}";
            using (var fs = File.Open(output, FileMode.Create))
                using (var writer = new StreamWriter(fs))
                    writer.Write(docCode);
        }
    }
}
