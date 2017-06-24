using System.Collections.Generic;

namespace Portella.Transformer.Core.FromTo
{
    public interface IService
    {
        IEnumerable<string> FromTo(IModel model);
    }
}