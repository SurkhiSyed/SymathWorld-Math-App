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
    public partial class Unit1Screen : Form
    {
        public Unit1Screen()
        {

        }
        public Unit1Screen(string value)
        {
            InitializeComponent();
            //Score_Label.Text = value;
            this.Value = value;
        }
        private void Unit1Screen_Load(object sender, EventArgs e)
        {
            Score_Label.Text = Value;
        }

        public string Value { get; set; }

        private void Theme1_btn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.anime_landscape_classic_japanese_wallpaper;
        }

        private void Theme2_btn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.old_house_japan_autumn_leaves_thumb;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Unit1Screen Score = new Unit1Screen(Score_Label.Text);
            Score.ShowDialog(); 
            this.Hide();
            new MainMenu().Show();
        }

        private void Lesson1_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Unit1Lesson1().Show();
        }

        private void Score_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
