// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class NotNullWhenTrueAttribute : Attribute
    {
        public NotNullWhenTrueAttribute() { }
    }
}