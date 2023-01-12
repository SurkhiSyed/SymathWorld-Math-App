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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Unit1_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Unit1Screen().Show();
        }

        private void HomeScreen_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainScreen().Show();
        }

        private void Theme1_btn_Click(object sender, EventArgs e)
        { 
            this.BackgroundImage = Properties.Resources.anime_landscape_classic_japanese_wallpaper;
        }

        private void Theme2_btn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.old_house_japan_autumn_leaves_thumb;
        }
    }
}
