using FluentAssertions;
using Teqniqly.Hyrule.Intermediate;
using Xunit;

namespace Teqniqly.Hyrule.Frontend.Tests
{
    public class ParserTests
    {
        private readonly Parser parser;

        public ParserTests()
        {
            parser = new TestParser(new StubScanner());
        }

        [Fact]
        public void Intermediate_Code_Property_Is_Null()
        {
            // Assert
            parser.GetProtectedProperty<ICode>("IntermediateCode").Should().BeNull();
        }

        [Fact]
        public void Symbol_Table_Property_Is_Null()
        {
            // Assert
            parser.GetProtectedProperty<ICode>("SymbolTable").Should().BeNull();
        }

        [Fact]
        public void Error_Count_Is_Zero()
        {
            // Assert
            parser.ErrorCount.Should().Be(0);
        }

        [Fact]
        public void Calls_Scanner_To_Get_CurrentToken()
        {
            // Act
            var token = parser.CurrentToken;

            // Assert
            token.Should().NotBeNull();
        }

        [Fact]
        public void Calls_Scanner_To_Get_NextToken()
        {
            // Act
            var token = parser.NextToken;

            // Assert
            token.Should().NotBeNull();
        }
    }
}