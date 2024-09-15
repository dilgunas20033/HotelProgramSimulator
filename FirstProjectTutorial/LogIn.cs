namespace FirstProjectTutorial
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //////////////////////////////////////////
        /// Clicks
        //////////////////////////////////////////

        private void button2_Click(object sender, EventArgs e)
        {


            if (password.Text == "admin" && email.Text == "admin")
            {
                Admin signed = new Admin();
                signed.ShowDialog();
                this.Close();

            }
            if (password.Text == "user" && email.Text == "user")
            {
                User signed = new User();
                signed.ShowDialog();
                this.Close();
            }
            if (password.Text == "" || email.Text == "")
            {
                ErrorSignin error = new ErrorSignin();
                error.ShowDialog();
            }
            else
            {
                ErrorWrong error = new ErrorWrong();
                error.ShowDialog();
            }
        }

        //////////////////////////////////////////
        /// Key Presses
        //////////////////////////////////////////

        private void signinButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signinButton.PerformClick();
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signinButton.PerformClick();
            }
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signinButton.PerformClick();
            }
        }

        //////////////////////////////////////////
        /// Key Presses
        //////////////////////////////////////////

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        //////////////////////////////////////////
        /// Timer
        //////////////////////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeShown.Text = DateTime.Now.ToString("MMM/dd/yyyy | hh:mm:ss tt");
        }
    }
}