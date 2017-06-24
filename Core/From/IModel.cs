namespace Portella.Transformer.Core.From
{
    public interface IModel
    {
        Edge.IModel Edge { get; set; }
        Target.IModel Target { get; set; }
    }
}
