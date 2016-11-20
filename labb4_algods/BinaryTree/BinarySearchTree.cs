using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace BinaryTree
{
    /// <summary>
    /// En typ som representerar ett binärt sökträd (BST).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        BinarySearchTreeNode<T> _root;

        /// <summary>
        /// Roten i sökträdet.
        /// </summary>
        public BinarySearchTreeNode<T> Root
        {
            get { return _root; }
        }


        // draw
        public Image Draw()
        {
            GC.Collect();// collects the unreffered locations on the memory
            int temp;
            return _root.RightChild == null ? null : _root.RightChild.Draw(out temp);
        }
        /// <summary>
        /// Initierar ett tomt sökträd.
        /// </summary>
        public BinarySearchTree()
        {

        }

        /// <summary>
        /// Initierar ett sökträd med en given rot.
        /// </summary>
        public BinarySearchTree(BinarySearchTreeNode<T> root)
        {
            _root = root;
        }

        /// <summary>
        /// Lägger till ett värde i sökträdet.
        /// </summary>
        /// <param name="value">Värdet som läggs till.</param>
        public bool Insert(T value)
        {
            if (_root != null)
            {
                _root.Insert(value);
            }
            else
            {
                _root = new BinarySearchTreeNode<T>(value);
            }

            return true;
        }

        /// <summary>
        /// Tar bort ett värde ur sökträdet.
        /// </summary>
        /// <param name="value">Värdet som ska tas bort.</param>
        public bool Remove(T value)
        {
            // Ifall roten är tom så kan vi ej ta bort något
            if (_root == null)
                return false;

            // ifall det finns ett vänster- eller högerbarn
            // låt noden hantera borttagandet av värdet
            if (_root.LeftChild != null || _root.RightChild != null)
            {
                _root.Remove(value);
            }
            // ifall det finns en rot men ej några barn-noder
            // kontrollera ifall roten innehåller det sökta värdet
            else if (_root.Value.CompareTo(value) == 0)
            {
                _root = null;
            }
            return true;
        }

        /// <summary>
        /// Letar efter visst värde i sökträdet.
        /// </summary>
        /// <param name="value">Värdet att leta efter.</param>
        public bool Find(T value)
        {
            if (_root != null)
                return _root.Find(value);
            else
                return false;
        }

        /// <summary>
        /// Returnerar en lista med alla värden i sökträdet i inorder.
        /// </summary>
        public IEnumerable<T> Inorder()
        {
            if (_root != null)
                return _root.Inorder();
            else
                return new List<T>();
        }

        /// <summary>
        /// Returnerar en lista med alla värden i sökträdet i postorder.
        /// </summary>
        public IEnumerable<T> Postorder()
        {
            if (_root != null)
                return _root.Postorder();
            else
                return new List<T>();
        }

        /// <summary>
        /// Returnerar en lista med alla värden i sökträdet i preorder.
        /// </summary>
        public IEnumerable<T> Preorder()
        {
            if (_root != null)
                return _root.Preorder();
            else
                return new List<T>();
        }
    }
}
