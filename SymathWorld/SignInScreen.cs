using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymathWorld
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if((Username_txt.Text == "Mayer") && (Password_txt.Text == "Start"))
            {
                this.Hide();
                new GateWay().Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password, try again!");
            }
        }
    }
}
