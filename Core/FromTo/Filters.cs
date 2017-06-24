

namespace Portella.Transformer.Core.FromTo
{
    using System.Collections;
    using System.Collections.Generic;

    public class Filters : ICollection<Filter>
    {
        ICollection<Filter> _expressions;

        public int Count => _expressions.Count;

        public bool IsReadOnly => _expressions.IsReadOnly;

        public Filters(ICollection<Filter> expression)
        {
            _expressions = expression;
        }

        public IEnumerator<Filter> GetEnumerator() => _expressions.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _expressions.GetEnumerator();

        public void Add(Filter expression)
        {
            _expressions.Add(expression);
        }

        public void Clear()
        {
            _expressions.Clear();
        }

        public bool Contains(Filter expression) => _expressions.Contains(expression);

        public void CopyTo(Filter[] array, int arrayIndex)
        {
            _expressions.CopyTo(array, arrayIndex);
        }

        public bool Remove(Filter expression) => _expressions.Remove(expression);
    }
}
