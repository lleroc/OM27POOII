namespace Floricola
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void button3_Click(object sender, EventArgs e)
        {
           var dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }

    
}
