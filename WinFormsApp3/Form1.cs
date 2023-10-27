namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 a = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.ShowDialog();
            this.Show();
            Close();    
        }
    }
}