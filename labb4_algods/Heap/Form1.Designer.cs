namespace Heap
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HeapNumbers = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.queue = new System.Windows.Forms.TextBox();
            this.Enqueue = new System.Windows.Forms.Button();
            this.Dequeue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.peek = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.peekBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MinHeap values:";
            // 
            // HeapNumbers
            // 
            this.HeapNumbers.Location = new System.Drawing.Point(29, 239);
            this.HeapNumbers.Name = "HeapNumbers";
            this.HeapNumbers.Size = new System.Drawing.Size(217, 20);
            this.HeapNumbers.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(28, 111);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(261, 57);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(29, 46);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(260, 59);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(28, 200);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(59, 20);
            this.InputBox.TabIndex = 4;
            this.InputBox.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add/Remove:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(476, 254);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(89, 20);
            this.input.TabIndex = 7;
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(390, 254);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(80, 20);
            this.priority.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioritet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input:";
            // 
            // queue
            // 
            this.queue.Location = new System.Drawing.Point(390, 293);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(260, 20);
            this.queue.TabIndex = 11;
            // 
            // Enqueue
            // 
            this.Enqueue.Location = new System.Drawing.Point(390, 98);
            this.Enqueue.Name = "Enqueue";
            this.Enqueue.Size = new System.Drawing.Size(260, 59);
            this.Enqueue.TabIndex = 12;
            this.Enqueue.Text = "Enqueue";
            this.Enqueue.UseVisualStyleBackColor = true;
            this.Enqueue.Click += new System.EventHandler(this.Enqueue_Click);
            // 
            // Dequeue
            // 
            this.Dequeue.Location = new System.Drawing.Point(390, 163);
            this.Dequeue.Name = "Dequeue";
            this.Dequeue.Size = new System.Drawing.Size(260, 59);
            this.Dequeue.TabIndex = 13;
            this.Dequeue.Text = "Dequeue";
            this.Dequeue.UseVisualStyleBackColor = true;
            this.Dequeue.Click += new System.EventHandler(this.Dequeue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kö:";
            // 
            // peek
            // 
            this.peek.Location = new System.Drawing.Point(390, 33);
            this.peek.Name = "peek";
            this.peek.Size = new System.Drawing.Size(260, 59);
            this.peek.TabIndex = 15;
            this.peek.Text = "Peek";
            this.peek.UseVisualStyleBackColor = true;
            this.peek.Click += new System.EventHandler(this.peek_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Peek:";
            // 
            // peekBox
            // 
            this.peekBox.Location = new System.Drawing.Point(571, 254);
            this.peekBox.Name = "peekBox";
            this.peekBox.Size = new System.Drawing.Size(79, 20);
            this.peekBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 402);
            this.Controls.Add(this.peekBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.peek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dequeue);
            this.Controls.Add(this.Enqueue);
            this.Controls.Add(this.queue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.HeapNumbers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeapNumbers;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox queue;
        private System.Windows.Forms.Button Enqueue;
        private System.Windows.Forms.Button Dequeue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button peek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox peekBox;
    }
}

