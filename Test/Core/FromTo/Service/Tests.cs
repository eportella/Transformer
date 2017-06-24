
namespace Portella.Transformer.Test.Core.FromTo.Service
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Portella.Transformer.Exceptions;

    [TestClass]
    public class Tests
    {
        [TestMethod, ExpectedException(typeof(NotNullSourceException), "Source can not be null")]
        public void NOT_NULL_SOURCE_ON_CREATE_SERVICE()
        {
            var svc = new Transformer.Core.FromTo.Service(null);
        }
    }
}
