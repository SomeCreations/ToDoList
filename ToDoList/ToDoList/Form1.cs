using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int check = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            check++;

            CheckBox box;

            box = new CheckBox();
            box.Text = textBox1.Text;
            box.AutoSize = true;
            box.Location = new Point(12, 27 * check);

            this.Controls.Add(box);
            
        }
    }
}
