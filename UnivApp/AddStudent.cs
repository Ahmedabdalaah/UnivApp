using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivApp
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertData insert;
            Check che = new Check();
            string firstname;
            string lastname ;
            string email;
            string department;
            try
            {
                firstname = textBox1.Text;
                lastname = textBox2.Text;
                email = textBox3.Text;
                department = textBox4.Text;
                if((che.checkName(firstname))&& (che.checkName(lastname))&&
                        (che.checkEmail(email)) && (che.checkName(department)))
                {
                    insert = new InsertData("student.txt", firstname, lastname, email, department);
                    MessageBox.Show("Data is added succefully");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else if (!che.checkName(firstname))
                {
                    textBox1.Focus();
                    MessageBox.Show("Invalid first name , try again");
                }
                else if (!che.checkName(lastname))
                {
                    textBox2.Text = "";
                    MessageBox.Show("Invalid last name , try again");
                }
                else if (!che.checkEmail(email))
                {
                    textBox3.Focus();
                    MessageBox.Show("Invalid email , try again ");
                }
                else if (!che.checkName(department))
                {
                    MessageBox.Show("Invalid department , try again");
                    textBox4.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
