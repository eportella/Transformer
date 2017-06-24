namespace Portella.Transformer.Core.Swap
{
    public interface IModel
    {
        string Value { get; set; }
        int EdgeId { get; set; }
        int TargetId { get; set; }
        int? TieId { get; set; }
        Edge.IModel Edge { get; set; }
        Target.IModel Target { get; set; }
        Tie.IModel Tie { get; set; }
    }
}
