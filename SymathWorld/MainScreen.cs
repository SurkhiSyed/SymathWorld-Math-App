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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Begin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignInScreen().Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            new SignInScreen().Hide();
            new GateWay().Hide();
            new MainMenu().Hide();
            new Unit1Screen().Hide();
        }
    }
}
