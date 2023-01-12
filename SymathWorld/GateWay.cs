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
    public partial class GateWay : Form
    {
        public GateWay()
        {
            InitializeComponent();
        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            await Task.Delay(4000);
            this.Hide();
            new MainMenu().Show();
        }
    }
}
