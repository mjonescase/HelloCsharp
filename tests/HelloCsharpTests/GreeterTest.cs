using System;
using Xunit;
using HelloCsharp;

namespace HelloCsharpTests
{
    public class GreeterTest
    {
        [Fact]
        public void GetGreeting()
        {
            string greeting = "hello world";
            Assert.True(greeting.Equals(new Greeter(greeting).Greet()));
        }
    }
}
