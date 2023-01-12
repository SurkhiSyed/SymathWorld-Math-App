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
    public partial class Unit1Lesson1 : Form
    {
        public static Unit1Lesson1 instance;
        public Label Score;
        public Unit1Lesson1()
        {
            InitializeComponent();

        }
        private void CheckAnswer_btn_Click(object sender, EventArgs e)
        {
            if(Answer_txt.Text == (Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text)).ToString())
            {
                Score_Label.Text = (Convert.ToInt32(Score_Label.Text) + 1).ToString();
                Random random = new Random();
                Num1.Text = (random.Next(0, 10)).ToString();
                Num2.Text = (random.Next(0, 10)).ToString();
                Answer_txt.Text = "";
            }
            else
            {
                Random random = new Random();
                Num1.Text = (random.Next(0, 10)).ToString();
                Num2.Text = (random.Next(0, 10)).ToString();
                Answer_txt.Text = "";
            }
        }

        private void GoBack_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Unit1Screen().Show();
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
