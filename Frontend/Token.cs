namespace Teqniqly.Hyrule.Frontend
{
    public class Token
    {
        private int lineNumber;
        private int position;

        protected string Text { get; set; }
        protected object Value { get; set; }

        protected char CurrentChar { get; }
        protected char NextChar { get; }

        protected ITokenType TokenType { get; }

        protected void Extract()
        {
        }

        protected char PeekChar()
        {
            return default;
        }
    }
}