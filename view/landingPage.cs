using Online_Library.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Library
{
    public partial class landingPage : Form
    {
        public landingPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login Login = new login(); // Pass current form (Form1) to Form2
            Login.ShowDialog();
            this.Hide();
        }
    }
}
