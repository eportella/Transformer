namespace Portella.Transformer.Core.Edge
{
    using System.Collections.Generic;
    public interface IModel
    {
        string Code { get; set; }
        ICollection<Swap.IModel> Swap { get; set; }
    }
}
