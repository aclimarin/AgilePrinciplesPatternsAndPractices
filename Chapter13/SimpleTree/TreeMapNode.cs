namespace SimpleTree
{
    public class TreeMapNode
    {
        private static readonly int _left = 0;//less
        private static readonly int _right = 1;//greater
        private IComparable _key;
        private object _value;
        private TreeMapNode[] childNodes = new TreeMapNode[2];

        public TreeMapNode(IComparable key, object value)
        {
            _key = key;
            _value = value;
        }

        public object? Find(IComparable key)
        {
            if (key.CompareTo(_key) == 0) return _value;
            return FindSubNode(SelectSubNode(key), key);
        }

        private int SelectSubNode(IComparable key)
        {
            return key.CompareTo(_key) < 0 ? _left : _right;
        }

        private object? FindSubNode(int node, IComparable key)
        {
            return childNodes[node] == null ? null : childNodes[node].Find(key);
        }

        public void Add(IComparable key, object value)
        {
            if (key.CompareTo(_key) == 0)
                _value = value;
            else
                AddSubNode(SelectSubNode(key), key, value);
        }

        private void AddSubNode(int node, IComparable key, object value)
        {   
            if (childNodes[node] == null)
                childNodes[node] = new TreeMapNode(key, value);
            else
                childNodes[node].Add(key, value);
        }
    }
}