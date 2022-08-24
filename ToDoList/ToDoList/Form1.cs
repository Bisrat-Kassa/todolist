namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Add p = new Add
                {
                    name = textBox1.Text

                };
                p.save();
                Form2 grid = new Form2();
            }
            catch (Exception)
            {
                MessageBox.Show("Type mismatch");
            };
        }
    }
}