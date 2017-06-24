namespace Portella.Transformer.Core.FromTo
{
    public interface IModel
    {
        From.IModel From { get; set; }
        To.IModel To { get; set; }
        Filters Expressions { get; set; }
    }
}
