using System.Xml.Linq;

namespace passwordAnalyzer
{
    public partial class Fmr_app : Form
    {
        public Fmr_app()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmr_app_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("Key Press");

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key Down");


        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TextChanged");

            TextBox txt_password = (TextBox)this.Controls["txt_password"];
            Label lbl_level = (Label)this.Controls["lbl_level"];

            PasswordChecker pc = new PasswordChecker(txt_password.Text);
            string level = pc.check();
            lbl_level.Text = level;

            switch (level)
            {

                case "Very Weak":
                    lbl_level.ForeColor = Color.Red;
                    break;
                case "Weak":
                    lbl_level.ForeColor = Color.OrangeRed;
                    break;
                case "Moderate":
                    lbl_level.ForeColor = Color.CornflowerBlue;

                    break;
                case "Strong":
                    lbl_level.ForeColor = Color.Blue;

                    break;
            }

        }
    }
}