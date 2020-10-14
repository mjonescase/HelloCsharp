using System;

namespace HelloCsharp
{
    public class Greeter
    {
        private readonly string greeting;

        public Greeter(string greeting)
        {
            this.greeting = greeting;
        }

        public string Greet()
        {
            return greeting;
        }
    }
}
