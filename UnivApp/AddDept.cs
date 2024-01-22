using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivApp
{
    public partial class AddDept : Form
    {
        public AddDept()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check ch = new Check();
            InsertData insert;
            string name;
            try
            {
                name = textBox1.Text;
                if (ch.checkName(name))
                {
                    insert = new InsertData("Department.txt", name);
                    MessageBox.Show("success");
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Focus();
                    MessageBox.Show("Invalid department name , try again");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
