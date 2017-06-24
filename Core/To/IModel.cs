namespace Portella.Transformer.Core.To
{
    public interface IModel
    {
        Edge.IModel Edge { get; set; }
        Target.IModel Target { get; set; }
    }
}
