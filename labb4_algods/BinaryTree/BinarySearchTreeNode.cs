using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public partial class BinarySearchTreeNode<T> where T : IComparable<T>
    {
        public T Value
        {
            get;
            private set;
        }

        public BinarySearchTreeNode<T> LeftChild
        {
            get;
            set;
        }

        public BinarySearchTreeNode<T> RightChild
        {
            get;
            set;
        }

        public BinarySearchTreeNode<T> Parent
        {
            get;
            set;
        }

        bool IsLeftChild
        {
            get
            {
                if (Parent == null)
                    return false;
                if (Value.CompareTo(Parent.Value) < 0)
                    return true;
                else
                    return false;
            }
        }

        bool IsRightChild
        {
            get
            {
                if (Parent == null)
                    return false;
                if (Value.CompareTo(Parent.Value) > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// konstruktor för klassen BinarySearchTreeNode
        /// </summary>
        /// <param name="value">infört värde av användaren</param>
        public BinarySearchTreeNode(T value) //konstruktor för klassen BinarySearchTreeNode
        {
            Value = value; //sätter värdet på Value likamed införda värdet.
        }

        /// <summary>
        /// för in en ny nod i trädet
        /// </summary>
        /// <param name="value">trädets potentiella nya värde</param>
        public void Insert(T value)
        {

            if (value.CompareTo(this.Value) > 0) //jämför infört värde med värdet i aktuella noden som genomsöks
            {

                if (RightChild == null) //om nodens högra barn är tomt
                {
                    RightChild = new BinarySearchTreeNode<T>(value); //skapar ny instans av typen BinarySearchTreeNode.
                    RightChild.Parent = this; //gör aktuell nod till förälder till den nyskapade noden
                }

                else
                {
                    RightChild.Insert(value); //om != null, anropa funktionen rekursivt
                }

            }
            else if (value.CompareTo(this.Value) < 0) //jämför infört värde med värdet i aktuella noden som genomsöks
            {
                if (LeftChild == null) //om nodens vänstra barn är tomt
                {
                    LeftChild = new BinarySearchTreeNode<T>(value); //skapar ny instans av typen BinarySearchTreeNode.
                    LeftChild.Parent = this; //gör aktuell nod till förälder till den nyskapade noden
                }
                else
                {
                    LeftChild.Insert(value); //om != null, anropa funktionen rekursivt
                }
            }

        }

        /// <summary>
        /// tar bort en nod med angivet värde från trädet
        /// </summary>
        /// <param name="value">värdet på norden som ska tas bort</param>
        public void Remove(T value)
        {

            if (value.CompareTo(Value) == 0) //om infört (eftersökt) värde hittas
            {
                Parent.IsChanged = true;

                if (LeftChild == null && RightChild == null) //om noden är ett löv
                {
                    if (IsRightChild == true) //om noden är ett högerbarn
                    {
                        Parent.RightChild = null;
                    }
                    else
                    {
                        Parent.LeftChild = null;
                    }
                }

                if (LeftChild == null && RightChild != null) //noden har endast ett högerbarn
                {
                    if (IsRightChild) //om noden har högerbarn
                    {
                        Parent.RightChild = RightChild;
                        RightChild.Parent = Parent;
                    }
                    else //om något undantag, dvs vänsterbarn skulle smita förbi
                    {
                        Parent.LeftChild = RightChild;
                        RightChild.Parent = Parent;
                    }
                }

                if (LeftChild != null && RightChild == null) //om noden har endast ett vänsterbarn
                {
                    if (IsLeftChild) //om noden har vänsterbarn 
                    {
                        Parent.LeftChild = LeftChild;
                        LeftChild.Parent = Parent;
                    }
                    else //om något undantag, dvs högerbarn, skulle smita förbi
                    {
                        Parent.RightChild = LeftChild;
                        LeftChild.Parent = Parent;
                    }
                }

                if (LeftChild != null && RightChild != null) //om noden har två barn, ett höger och ett vänster
                {
                    BinarySearchTreeNode<T> temp = LeftChild; //instantierar temporär variabel av klassen BinarySearchTreeNode som är ett vänsterbarn 
                    while (temp.RightChild != null) //går sålänge den tillfälliga variabeln, som rör sig mellan noder, har ett högerbarn
                        temp = temp.RightChild; //ge den temporära variabeln högerbarnets värde

                    this.Value = temp.Value; //ge det aktuella värdet den temporära variabelns värde

                    if (LeftChild != null) 
                    {
                        LeftChild.Remove(temp.Value);
                    }

                }
            }

            else if (value.CompareTo(this.Value) > 0)
            {
                RightChild.Remove(value);
            }

            else if (value.CompareTo(this.Value) < 0)
            {
                LeftChild.Remove(value);
            }
        }

        /// <summary>
        /// funktion som hittar ett angivet value i det binära sökträdet
        /// </summary>
        /// <param name="value">eftersökt värde</param>
        /// <returns>true om värdet redan finns i trädet, annars false</returns>
        public bool Find(T value)
        {

            if (value.CompareTo(this.Value) == 0) //om det införda värdet är detsamma som det som finns i aktuell nod
            {
                return true; //returnera true
            }
            else if (value.CompareTo(this.Value) < 0 && LeftChild != null) //om värdet på den aktuella noden är större än den eftersökta, och dess vänstra barn inte är null
            {
                return LeftChild.Find(value);
            }
            else if (value.CompareTo(this.Value) > 0 && RightChild != null) //om värdet på den aktuella noden är större än den eftersökta, och dess högra barn inte är null
            {
                return RightChild.Find(value); 
            }
            return false; //returnera false (värdet finns inte i trädet)

        }

        /// <summary>
        /// sorterar listan i inordning
        /// </summary>
        /// <returns>trädets noder i inordning</returns>
        public IEnumerable<T> Inorder()
        {
            List<T> inOrderList = new List<T>(); 
            
            if (this.Value != null)
            {
                if (LeftChild != null) //om vänsterbarnet inte är null, dvs finns
                {
                    inOrderList.AddRange(LeftChild.Inorder()); //lägger till aktuella värdets LeftChild och anropar funktionen rekursivt för att upprepa proceduren
                }
                    inOrderList.Add(this.Value);//lägger till aktuellt värde

                if (RightChild != null) //om högerbarnet inte är null, dvs finns
                {
                    inOrderList.AddRange(RightChild.Inorder()); //lägger till aktuella värdets RightChild och anropar funktionen rekursivt för att upprepa proceduren
                }
            }

            return inOrderList;
        }

        /// <summary>
        /// sorterar listan i postorder
        /// </summary>
        /// <returns>trädets noder i postorder</returns>
        public IEnumerable<T> Postorder()
        {
            List<T> postOrderList = new List<T>();

            if (this.Value != null)
            {
                if (LeftChild != null) //om vänsterbarnet inte är null, dvs finns
                {
                    postOrderList.AddRange(LeftChild.Postorder()); //lägger till aktuella värdets LeftChild och anropar funktionen rekursivt för att upprepa proceduren
                }

                if (RightChild != null) //om högerbarnet inte är null, dvs finns
                {
                    postOrderList.AddRange(RightChild.Postorder()); //lägger till aktuella värdets RightChild och anropar funktionen rekursivt för att upprepa proceduren
                }

                postOrderList.Add(this.Value);//lägger till aktuellt värde
            }

            return postOrderList;
        }

        /// <summary>
        /// sorterar listans noder i preordning
        /// </summary>
        /// <returns>listans noder i preorder</returns>
        public IEnumerable<T> Preorder()
        {

            List<T> PreOrderList = new List<T>();

            if (this.Value != null)
            {
                PreOrderList.Add(this.Value); //lägger till aktuellt värde

                if (LeftChild != null) //om vänsterbarnet inte är null, dvs finns
                {
                    PreOrderList.AddRange(LeftChild.Preorder());
                }
                if (RightChild != null) //om högerbarnet inte är null, dvs finns
                {
                    PreOrderList.AddRange(RightChild.Preorder());
                }
            }

            return PreOrderList;
        }
    }
}
