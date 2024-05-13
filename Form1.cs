namespace finalooadproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loginform lgf = new loginform();
            lgf.Show();
            Form1 f1 = new Form1();
            f1.Hide();

        }

    }
}
