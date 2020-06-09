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
        public const string argTemplate =
@"| {0} | {1} | {2} |";

        public const string messageTemplate =
@"- Message {0}

| arg | type | description |
| ----- | ----- | ----- |
{1}";

        public const string typeTemplate =
@"- Type {0}

| field | type | description |
| ----- | ----- | ----- |
{1}";

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
            var docCode = "# Terraria protocol\n";

            foreach (var type in loader.types)
            {
                var words = type.Key.Split('_');
                bool isMessage;
                if (words.Length != 2)
                    continue;
                var name = "";
                if (words[0] == "type")
                {
                    name = words[1];
                    isMessage = false;
                }
                else if (int.TryParse(words[0], out var messageId))
                {
                    name = type.Key;
                    isMessage = true;
                }
                else
                    continue;

                if (isMessage)
                    docCode += msgCodeGenerator.Generate($"[{words[0]}]{words[1]}", type.Value);
                else
                    docCode += typeCodeGenerator.Generate(name, type.Value);

                docCode += "\n";
            }

            docCode +=
$@"----
Generate at {DateTime.Now}";
            using (var outputFile = File.Open(output, FileMode.Create))
            using (var writer = new StreamWriter(outputFile))
                writer.Write(docCode);
        }
    }
}
