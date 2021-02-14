using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit.Sdk;

namespace AdventOfCode.Tests
{
    internal class InputFileDataAttribute : DataAttribute
    {
        private readonly string _filePath;

        public InputFileDataAttribute(string filePath)
        {
            _filePath = filePath;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var fileInfo = new FileInfo(_filePath);
            var parameterInfo = testMethod.GetParameters().First();
            var type = parameterInfo.ParameterType;

            if (type.IsArray)
            {
                type = type.GetElementType();
            }

            var data = new List<object>();

            using StreamReader streamReader = fileInfo.OpenText();
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();

                if (!string.IsNullOrEmpty(line))
                {
                    data.Add(Convert.ChangeType(line, type));
                }
            }

            return new[] { data.ToArray() };
        }
    }
}
