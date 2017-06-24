namespace Portella.Transformer.Core.Tie
{
    using System.Collections.Generic;
    public interface IModel
    {
        ICollection<Swap.IModel> Swap { get; set; }
    }
}
