namespace SymathWorld
{
    partial class Unit1Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lesson1_btn = new System.Windows.Forms.Button();
            this.Lessons_Label = new System.Windows.Forms.Label();
            this.Lesson2_btn = new System.Windows.Forms.Button();
            this.Lesson3_btn = new System.Windows.Forms.Button();
            this.Theme1_btn = new System.Windows.Forms.Button();
            this.Theme2_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.PictureBox();
            this.ScoreName_Label = new System.Windows.Forms.Label();
            this.Score_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Lesson1_btn
            // 
            this.Lesson1_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lesson1_btn.Location = new System.Drawing.Point(12, 103);
            this.Lesson1_btn.Name = "Lesson1_btn";
            this.Lesson1_btn.Size = new System.Drawing.Size(355, 47);
            this.Lesson1_btn.TabIndex = 0;
            this.Lesson1_btn.Text = "Lesson 1: Adding Numbers";
            this.Lesson1_btn.UseVisualStyleBackColor = true;
            this.Lesson1_btn.Click += new System.EventHandler(this.Lesson1_btn_Click);
            // 
            // Lessons_Label
            // 
            this.Lessons_Label.AutoSize = true;
            this.Lessons_Label.BackColor = System.Drawing.Color.Transparent;
            this.Lessons_Label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lessons_Label.ForeColor = System.Drawing.Color.White;
            this.Lessons_Label.Location = new System.Drawing.Point(218, 24);
            this.Lessons_Label.Name = "Lessons_Label";
            this.Lessons_Label.Size = new System.Drawing.Size(364, 65);
            this.Lessons_Label.TabIndex = 1;
            this.Lessons_Label.Text = "Unit 1: Lessons";
            // 
            // Lesson2_btn
            // 
            this.Lesson2_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lesson2_btn.Location = new System.Drawing.Point(12, 170);
            this.Lesson2_btn.Name = "Lesson2_btn";
            this.Lesson2_btn.Size = new System.Drawing.Size(355, 47);
            this.Lesson2_btn.TabIndex = 2;
            this.Lesson2_btn.Text = "Lesson 2: Subtract Numbers";
            this.Lesson2_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Lesson2_btn.UseVisualStyleBackColor = true;
            // 
            // Lesson3_btn
            // 
            this.Lesson3_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lesson3_btn.Location = new System.Drawing.Point(12, 237);
            this.Lesson3_btn.Name = "Lesson3_btn";
            this.Lesson3_btn.Size = new System.Drawing.Size(355, 47);
            this.Lesson3_btn.TabIndex = 3;
            this.Lesson3_btn.Text = "Lesson 3: Shapes";
            this.Lesson3_btn.UseVisualStyleBackColor = true;
            // 
            // Theme1_btn
            // 
            this.Theme1_btn.Location = new System.Drawing.Point(44, 383);
            this.Theme1_btn.Name = "Theme1_btn";
            this.Theme1_btn.Size = new System.Drawing.Size(42, 44);
            this.Theme1_btn.TabIndex = 4;
            this.Theme1_btn.Text = "1";
            this.Theme1_btn.UseVisualStyleBackColor = true;
            this.Theme1_btn.Click += new System.EventHandler(this.Theme1_btn_Click);
            // 
            // Theme2_btn
            // 
            this.Theme2_btn.Location = new System.Drawing.Point(107, 383);
            this.Theme2_btn.Name = "Theme2_btn";
            this.Theme2_btn.Size = new System.Drawing.Size(42, 44);
            this.Theme2_btn.TabIndex = 5;
            this.Theme2_btn.Text = "2";
            this.Theme2_btn.UseVisualStyleBackColor = true;
            this.Theme2_btn.Click += new System.EventHandler(this.Theme2_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.Image = global::SymathWorld.Properties.Resources.Left_Arrow_Icon_PNG_Pic;
            this.Back_btn.Location = new System.Drawing.Point(35, 24);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(63, 65);
            this.Back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_btn.TabIndex = 6;
            this.Back_btn.TabStop = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ScoreName_Label
            // 
            this.ScoreName_Label.AutoSize = true;
            this.ScoreName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreName_Label.Location = new System.Drawing.Point(646, 402);
            this.ScoreName_Label.Name = "ScoreName_Label";
            this.ScoreName_Label.Size = new System.Drawing.Size(76, 25);
            this.ScoreName_Label.TabIndex = 7;
            this.ScoreName_Label.Text = "Score:";
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.Location = new System.Drawing.Point(729, 403);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(24, 25);
            this.Score_Label.TabIndex = 8;
            this.Score_Label.Text = "0";
            this.Score_Label.Click += new System.EventHandler(this.Score_Label_Click);
            // 
            // Unit1Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SymathWorld.Properties.Resources.anime_landscape_classic_japanese_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.ScoreName_Label);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Theme2_btn);
            this.Controls.Add(this.Theme1_btn);
            this.Controls.Add(this.Lesson3_btn);
            this.Controls.Add(this.Lesson2_btn);
            this.Controls.Add(this.Lessons_Label);
            this.Controls.Add(this.Lesson1_btn);
            this.Name = "Unit1Screen";
            this.Text = "Unit 1";
            this.Load += new System.EventHandler(this.Unit1Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lesson1_btn;
        private System.Windows.Forms.Label Lessons_Label;
        private System.Windows.Forms.Button Lesson2_btn;
        private System.Windows.Forms.Button Lesson3_btn;
        private System.Windows.Forms.Button Theme1_btn;
        private System.Windows.Forms.Button Theme2_btn;
        private System.Windows.Forms.PictureBox Back_btn;
        private System.Windows.Forms.Label ScoreName_Label;
        private System.Windows.Forms.Label Score_Label;
    }
}