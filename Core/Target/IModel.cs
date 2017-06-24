namespace Portella.Transformer.Core.Target
{
    using System.Collections.Generic;
    public interface IModel
    {
        string Code { get; set; }
        ICollection<Swap.IModel> Swap { get; set; }
    }
}
