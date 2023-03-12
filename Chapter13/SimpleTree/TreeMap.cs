using System;

namespace SimpleTree{
    public class TreeMap{
        private TreeMapNode topNode = null;

        public void Add(IComparable key, object value){
            if (topNode == null)
                topNode = new TreeMapNode(key, value);
            else
                topNode.Add(key, value);
        }

        public object? Get(IComparable key){
            return topNode == null ? null : topNode.Find(key);
        }
    }
}