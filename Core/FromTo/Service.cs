namespace Portella.Transformer.Core.FromTo
{
    using Exceptions;
    using System.Collections.Generic;
    public class Service : IService
    {
        Source.IService Source { get; set; }
        public Service(Source.IService source)
        {
            Source = source ?? throw new NotNullSourceException();
        }

        public IEnumerable<string> FromTo(IModel model) => Source.FromTo(model);
    }
}
