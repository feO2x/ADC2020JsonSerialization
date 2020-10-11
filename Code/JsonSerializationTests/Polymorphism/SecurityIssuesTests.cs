using System;
using System.IO;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace JsonSerializationTests.Polymorphism
{
    public sealed class SecurityIssuesTests
    {
        private readonly ITestOutputHelper _output;

        public SecurityIssuesTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void MakeFileReadOnly()
        {
            File.WriteAllText("text.txt", "Hello to all at ADC 2020!");

            const string maliciousJson = @"
{
    ""$type"": ""System.IO.FileInfo, System.IO.FileSystem"",
    ""fileName"": ""text.txt"",
    ""isReadOnly"": true
}";

            try
            {
                JsonConvert.DeserializeObject<object>(maliciousJson, JsonSettings.NewtonsoftJsonPolymorphicSettings);
            }
            catch (Exception exception)
            {
                _output.WriteLine(exception.ToString());
            }

            new FileInfo("text.txt").IsReadOnly.Should().BeTrue();
        }
    }
}