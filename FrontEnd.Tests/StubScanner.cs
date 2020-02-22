using System;

namespace Teqniqly.Hyrule.Frontend.Tests
{
    internal class StubScanner : Scanner
    {
        protected override Token ExtractToken()
        {
            throw new NotImplementedException();
        }

        public override Token CurrentToken => new Token();
        public override Token NextToken => new Token();
    }
}