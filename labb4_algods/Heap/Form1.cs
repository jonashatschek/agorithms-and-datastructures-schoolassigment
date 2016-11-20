using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoDS_Labb3;

namespace Heap
{
    public partial class Form1 : Form
    {

        MinHeap<int> heap = new MinHeap<int>();
        PriorityQueue<int, int> queue2 = new PriorityQueue<int, int>(10);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// lägger till ett element i heapen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                heap.Add(Convert.ToInt32(InputBox.Text)); 
                HeapNumbers.Text = heap.ToString();
                input.Clear();
            }
            catch (FormatException) //om användaren försöker lägga in ett element utan att ha skrivit in värde
            {
                MessageBox.Show("Invalid input.");
            }
        }

        /// <summary>
        /// tar bort ett element ur heapen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                heap.Remove(Convert.ToInt32(InputBox.Text));
                HeapNumbers.Text = heap.ToString();
                input.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input."); //om användaren försöker ta bort siffror ur en tom heap
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Invalid input.");
            }
        }

        /// <summary>
        /// stoppar in ett nytt element i queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enqueue_Click(object sender, EventArgs e)
        {
            try
            {

                int value = int.Parse(input.Text);
                int prio = int.Parse(priority.Text);

                queue2.Enqueue(value, prio);
                queue.Text = queue2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.");
            }

        }

        /// <summary>
        /// plockar bort det element med högst prioritet i queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dequeue_Click(object sender, EventArgs e)
        {

            try
            {
                queue2.Dequeue();
                queue.Text = queue2.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Queue is empty."); //om kön inte innehåller fler element
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Invalid input.");
            }
        }

        /// <summary>
        /// visar första siffran i queuen i en textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peek_Click(object sender, EventArgs e)
        {

            try
            {
                int temporary = queue2.Peek();
                string p = temporary.ToString();
                queue2.Peek();
                peekBox.Text = p;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Queue is empty.");
            }
        }
    }
}
