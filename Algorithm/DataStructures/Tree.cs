using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        public int Count { get; set; }
        public Tree()
        {

        }

        public Tree(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }
        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;

        }
        public List<T> Inorder0()
        {
            var list = new List<T>();

            if (Root == null)
            {
                return list;
            }
            return Inorder01(Root);
        }
        private List<T> Inorder01(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder01(node.Left));//AddRange(ICollection collection): добавление в список коллекции или массива
                }
                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inorder01(node.Right));
                }

            }
            return list;
        }

    }
}
