using StationManager.Forms;

namespace StationManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
        }
    }
}
