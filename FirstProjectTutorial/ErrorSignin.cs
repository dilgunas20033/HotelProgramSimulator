using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectTutorial
{
    public partial class ErrorSignin : Form
    {
        public ErrorSignin()
        {
            InitializeComponent();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
