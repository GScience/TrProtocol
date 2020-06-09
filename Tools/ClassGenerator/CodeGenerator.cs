using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    public class CodeGenerator
    {
        private string _classTemplate;
        private string _fieldDefineTemplate;

        public CodeGenerator(
            string classTemplate, 
            string fieldTemplate)
        {
            _classTemplate = classTemplate;
            _fieldDefineTemplate = fieldTemplate;
        }

        public string Generate(string name, TypeInfo typeInfo)
        {
            var fieldDefinesCode = "";
            var fieldSerializationCode = "";
            var fieldDeserializationCode = "";
            
            foreach (var field in typeInfo.args)
            {
                var defineCode = "";

                // Field defination
                var defaultValue = "";
                var typeName = "";
                var fieldName = field.name;

                switch (field.type)
                {
                    case "long":
                    case "int":
                    case "short":
                    case "sbyte":
                    case "ulong":
                    case "uint":
                    case "ushort":
                    case "byte":
                    case "float":
                    case "string":
                        defaultValue = $"default({field.type})";
                        typeName = field.type;
                        break;
                    default:
                        // Array
                        if (field.type.Contains("["))
                        {
                            var words = field.type.Split('[', ']');
                            if (words.Length != 3)
                                throw new Exception($"Not an invalid array type: {field.type}");
                            if (int.TryParse(words[1], out var arraySize))
                                throw new Exception($"Not an invalid array size: {words[1]}");

                            typeName = words[0];
                            defaultValue = $"new {typeName}[{arraySize}]";
                        }
                        else
                        {
                            typeName = field.type;
                            defaultValue = $"new {typeName}";
                        }
                        break;
                }
                defineCode = string.Format(_fieldDefineTemplate, typeName, fieldName, defaultValue, field.desc);

                // field serialization
                var deserializationCode = "";
                var serializationCode = "";

                switch (field.type)
                {
                    case "long":
                        deserializationCode = $"{fieldName} = reader.ReadInt64();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "int":
                        deserializationCode = $"{fieldName} = reader.ReadInt32();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "short":
                        deserializationCode = $"{fieldName} = reader.ReadInt16();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "sbyte":
                        deserializationCode = $"{fieldName} = reader.ReadSByte();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "ulong":
                        deserializationCode = $"{fieldName} = reader.ReadUInt64();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "uint":
                        deserializationCode = $"{fieldName} = reader.ReadUInt32();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "ushort":
                        deserializationCode = $"{fieldName} = reader.ReadUInt16();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "byte":
                        deserializationCode = $"{fieldName} = reader.ReadByte();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "float":
                        deserializationCode = $"{fieldName} = reader.ReadSingle();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    case "string":
                        deserializationCode = $"{fieldName} = reader.ReadString();";
                        serializationCode = $"writer.Write({fieldName});";
                        break;
                    default:
                        deserializationCode = $"{fieldName}.OnDeserialize(reader);";
                        serializationCode = $"{fieldName}.OnSerialize(writer);";
                        break;
                }

                if (!string.IsNullOrEmpty(fieldDefinesCode))
                    fieldDefinesCode += "\n";
                if (!string.IsNullOrEmpty(fieldSerializationCode))
                    fieldSerializationCode += "\n";
                if (!string.IsNullOrEmpty(fieldDeserializationCode))
                    fieldDeserializationCode += "\n";

                fieldDefinesCode += defineCode;
                fieldSerializationCode += "            " + serializationCode;
                fieldDeserializationCode += "            " + deserializationCode;
            }

            var classCode = string.Format(
                _classTemplate, 
                name,
                fieldDefinesCode, 
                fieldSerializationCode,
                fieldDeserializationCode,
                typeInfo.desc);

            return classCode;
        }
    }
}
