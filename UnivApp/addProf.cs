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
    public partial class addProf : Form
    {
        public addProf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData insert;
            Check ch = new Check();
            string firstname;
            string lastname;
            int age;
            string email;
            string gender="";
            try
            {
                firstname = textBox1.Text;
                lastname = textBox2.Text;
                email = textBox3.Text;
                if (radioButton2.Checked)
                {
                    gender = "male";

                }
                else if (radioButton3.Checked)
                {
                    gender = "female";
                }
                else
                {
                    gender = "";
                }
                age = Convert.ToInt32(comboBox1.SelectedItem);
                if ((ch.checkName(firstname)) && (ch.checkName(lastname)) && 
                    (ch.checkEmail(email))&&(comboBox1.SelectedIndex!=1)&&(gender != ""))
                { 
                    insert = new InsertData("professor.txt", firstname, lastname, age, email);
                    MessageBox.Show(" success , data is inserted");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.SelectedIndex = -1;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                else if (ch.checkName(firstname) == false)
                {
                    textBox1.Focus();
                    MessageBox.Show("Invalid first name , try again");
                }
                else if (ch.checkName(lastname) == false)
                {
                    textBox2.Focus();
                    MessageBox.Show("Invalid last name , try again ");
                }
                else if (ch.checkEmail(email)== false)
                {
                    textBox3.Focus();
                    MessageBox.Show("Inavalid email , try again");
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    comboBox1.Focus();
                    MessageBox.Show("Invalid age ,select number ");
                }
                else if (gender == "")
                {
                    MessageBox.Show("Invalid gender ,select gender ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
