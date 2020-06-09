﻿using Newtonsoft.Json.Converters;
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
        private struct SerializationCodePair
        {
            public string serialization;
            public string deserialization;
        }

        private string _classTemplate;
        private string _fieldDefineTemplate;

        public CodeGenerator(
            string classTemplate, 
            string fieldTemplate)
        {
            _classTemplate = classTemplate;
            _fieldDefineTemplate = fieldTemplate;
        }

        private SerializationCodePair GenerateSerializationCode(string fieldName, string type, int depth = 0)
        {
            var code = new SerializationCodePair();

            switch (type)
            {
                case "long":
                    code.deserialization = $"{fieldName} = reader.ReadInt64();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "int":
                    code.deserialization = $"{fieldName} = reader.ReadInt32();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "short":
                    code.deserialization = $"{fieldName} = reader.ReadInt16();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "sbyte":
                    code.deserialization = $"{fieldName} = reader.ReadSByte();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "ulong":
                    code.deserialization = $"{fieldName} = reader.ReadUInt64();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "uint":
                    code.deserialization = $"{fieldName} = reader.ReadUInt32();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "ushort":
                    code.deserialization = $"{fieldName} = reader.ReadUInt16();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "byte":
                    code.deserialization = $"{fieldName} = reader.ReadByte();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "float":
                    code.deserialization = $"{fieldName} = reader.ReadSingle();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                case "string":
                    code.deserialization = $"{fieldName} = reader.ReadString();";
                    code.serialization = $"writer.Write({fieldName});";
                    break;
                default:
                    // Array
                    if (type.Contains("["))
                    {
                        var words = type.Split('[', ']');
                        if (words.Length != 3)
                            throw new Exception($"Not an invalid array type: {type}");
                        if (!int.TryParse(words[1], out var arraySize))
                            throw new Exception($"Not an invalid array size: {words[1]}");

                        var elementType = words[0];
                        var loopVarName = new string((char)('i' + depth), 1);
                        var elementSerialization = GenerateSerializationCode($"{fieldName}[{loopVarName}]", elementType);
                        code.deserialization = $"for (var {loopVarName} = 0; {loopVarName} < {arraySize}; ++{loopVarName}) " + elementSerialization.deserialization;
                        code.serialization = $"for (var {loopVarName} = 0; {loopVarName} < {arraySize}; ++{loopVarName}) " + elementSerialization.serialization;
                    }
                    else
                    {
                        code.deserialization = $"{fieldName}.OnDeserialize(reader);";
                        code.serialization = $"{fieldName}.OnSerialize(writer);";
                    }
                    break;
            }
            return code;
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
                            if (words.Length % 2 == 0)
                                throw new Exception($"Not an invalid array type: {field.type}");
                            if (!int.TryParse(words[1], out var arraySize))
                                throw new Exception($"Not an invalid array size: {words[1]}");

                            var elementType = words[0];
                            typeName = elementType + "[]";
                            defaultValue = $"new {elementType}[{arraySize}]";
                        }
                        else
                        {
                            typeName = field.type;
                            defaultValue = $"new {typeName}()";
                        }
                        break;
                }
                defineCode = string.Format(_fieldDefineTemplate, typeName, fieldName, defaultValue, field.desc);

                // field serialization
                var serializationCode = GenerateSerializationCode(fieldName, field.type);

                if (!string.IsNullOrEmpty(fieldDefinesCode))
                    fieldDefinesCode += "\n";
                if (!string.IsNullOrEmpty(fieldSerializationCode))
                    fieldSerializationCode += "\n";
                if (!string.IsNullOrEmpty(fieldDeserializationCode))
                    fieldDeserializationCode += "\n";

                fieldDefinesCode += defineCode;
                fieldSerializationCode += "            " + serializationCode.serialization;
                fieldDeserializationCode += "            " + serializationCode.deserialization;
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
