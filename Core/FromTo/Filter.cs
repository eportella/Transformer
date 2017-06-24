using System;
using System.Linq.Expressions;

namespace Portella.Transformer.Core.FromTo
{
    public class Filter
    {
        Expression<Func<IModel, bool>> E { get; set; }
        public Filter(Expression<Func<IModel, bool>> e)
        {
            E = e;
        }
    }
}
