namespace Teqniqly.Hyrule.Frontend
{
    public abstract class Scanner
    {
        public virtual Token CurrentToken { get; }

        public virtual Token NextToken { get; }

        public char CurrentChar { get; }
        public char NextChar { get; }

        protected abstract Token ExtractToken();
    }
}