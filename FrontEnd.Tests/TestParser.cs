using System;

namespace Teqniqly.Hyrule.Frontend.Tests
{
    internal class TestParser : Parser
    {
        public TestParser(Scanner scanner) : base(scanner)
        {
        }

        public override int ErrorCount { get; }

        public override void Parse()
        {
            throw new NotImplementedException();
        }
    }
}