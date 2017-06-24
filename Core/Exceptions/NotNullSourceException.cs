
namespace Portella.Transformer.Exceptions
{
    using System;

    public class NotNullSourceException : Exception
    {
        public NotNullSourceException() : base("Source can not be null")
        {

        }
    }
}
