namespace Teqniqly.Hyrule.Frontend
{
    public class Source
    {
        private ISourceReader reader;
        private string line;
        private int lineNumber;
        private int currentPosition;

        public char CurrentChar { get; }
        public char NextChar { get; }
    }
}