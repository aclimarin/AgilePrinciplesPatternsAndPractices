using System.Collections;

namespace Shape
{
    /// <summary>
    /// Esta comparador pesquisará o tipo de uma figura na tabela hashing de propriedades.
    /// A tabela de propriedades define a ordem das figuras. As figuras que não são encontradas
    /// precedem as que são
    /// </summary>
    public class ShapeComparer : IComparer
    {
        private static Hashtable _properties = new Hashtable();

        static ShapeComparer()
        {
            _properties.Add(typeof(Circle), 1);
            _properties.Add(typeof(Rectangle), 2);
            _properties.Add(typeof(Square), 3);
        }

        private int PriorityFor(Type type)
        {
            if (_properties.Contains(type))
                return (int)_properties[type];
            else
                return 0;
        }

        public int Compare(object o1, object o2)
        {
            int priority1 = PriorityFor(o1.GetType());
            int priority2 = PriorityFor(o2.GetType());

            return priority1.CompareTo(priority2);
        }
    }
}
