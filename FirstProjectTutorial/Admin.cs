using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectTutorial
{
    public partial class Admin : Form
    {

        public Admin()
        {
             InitializeComponent();
            
        }

        private void roomLayout()
        {
            panel3.Show();
            roomPanel.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }

        private void rooms_Click(object sender, EventArgs e)
        {
            bool clicks;
            if (clicks = true)
            {
                roomLayout();
                clicks = false; 
            }
            if (clicks = false)
            {
                panel3.Hide();
                roomPanel.Show();
                clicks = true;
            }        
        }
    }
}
