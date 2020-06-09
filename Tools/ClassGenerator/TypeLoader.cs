using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    public class TypeLoader
    {
        public Dictionary<string, TypeInfo> types = new Dictionary<string, TypeInfo>();

        public void Load(string rootPath)
        {
            // Read all type
            var paths = Directory.EnumerateFiles(rootPath);
            foreach (var path in paths)
            {
                var fileInfo = new FileInfo(path);

                using (var fileReader = File.OpenText(path))
                {
                    var json = fileReader.ReadToEnd();
                    var typeInfo = JsonConvert.DeserializeObject<TypeInfo>(json);
                    var fileName = fileInfo.Name.Substring(0, fileInfo.Name.Length - fileInfo.Extension.Length);
                    types.Add(fileName, typeInfo);
                }
            }
        }
    }
}
