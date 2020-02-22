using Teqniqly.Hyrule.Intermediate;

namespace Teqniqly.Hyrule.Frontend
{
    public abstract class Parser
    {
        protected Parser(Scanner scanner)
        {
            Scanner = scanner;
        }

        protected ICode IntermediateCode { get; }
        protected SymbolTable SymbolTable { get; }

        protected Scanner Scanner { get; }

        public abstract int ErrorCount { get; }

        public Token CurrentToken => Scanner.CurrentToken;

        public Token NextToken => Scanner.NextToken;

        public abstract void Parse();
    }
}