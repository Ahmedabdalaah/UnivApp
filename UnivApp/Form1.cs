namespace UnivApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProf addp = new addProf();
            addp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudent addS = new AddStudent();
            addS.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowPro showP = new ShowPro();
            showP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDept add = new AddDept();
            add.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCourse add = new AddCourse();
            add.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowStudent shows = new ShowStudent();
            shows.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowDept showd = new ShowDept();
            showd.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowCourse show = new ShowCourse();
            show.Show();
            this.Hide();
        }
    }
}
