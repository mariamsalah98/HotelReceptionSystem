namespace WinFormsApp1
{
    public partial class EntryPage : Form
    {
        public EntryPage()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login form = new login();
            form.Show();
        }
    }
}