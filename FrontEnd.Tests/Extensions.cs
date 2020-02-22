using System.Reflection;

namespace Teqniqly.Hyrule.Frontend.Tests
{
    public static class Extensions
    {
        public static TField GetProtectedProperty<TField>(
            this object obj,
            string propertyName)
        {
            var type = obj.GetType();

            var value = (TField) type.InvokeMember(
                propertyName,
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.GetProperty,
                null, obj,
                null);

            return value;
        }
    }
}