namespace Portella.Transformer.Core.Source
{
    using System.Collections.Generic;

    public interface IService
    {
        IEnumerable<string> FromTo(FromTo.IModel model);
    }
}
