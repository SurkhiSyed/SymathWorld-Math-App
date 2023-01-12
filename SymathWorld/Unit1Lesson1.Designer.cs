namespace SymathWorld
{
    partial class Unit1Lesson1
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
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Add_Label = new System.Windows.Forms.Label();
            this.AddImage = new System.Windows.Forms.PictureBox();
            this.EqualSignImage = new System.Windows.Forms.PictureBox();
            this.Answer_txt = new System.Windows.Forms.TextBox();
            this.CheckAnswer_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Score_Label = new System.Windows.Forms.Label();
            this.GoBack_btn = new System.Windows.Forms.PictureBox();
            this.Theme1_btn = new System.Windows.Forms.Button();
            this.Theme2_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqualSignImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBack_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(121, 221);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(91, 106);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "0";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(342, 221);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(91, 106);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "0";
            // 
            // Add_Label
            // 
            this.Add_Label.AutoSize = true;
            this.Add_Label.BackColor = System.Drawing.Color.Transparent;
            this.Add_Label.Font = new System.Drawing.Font("Segoe UI", 62F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Label.ForeColor = System.Drawing.Color.White;
            this.Add_Label.Location = new System.Drawing.Point(241, 22);
            this.Add_Label.Name = "Add_Label";
            this.Add_Label.Size = new System.Drawing.Size(351, 164);
            this.Add_Label.TabIndex = 2;
            this.Add_Label.Text = "Add!";
            // 
            // AddImage
            // 
            this.AddImage.BackColor = System.Drawing.Color.Transparent;
            this.AddImage.Image = global::SymathWorld.Properties.Resources.Blue_Add_Button_PNG_HD1;
            this.AddImage.Location = new System.Drawing.Point(253, 247);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(51, 50);
            this.AddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddImage.TabIndex = 3;
            this.AddImage.TabStop = false;
            // 
            // EqualSignImage
            // 
            this.EqualSignImage.BackColor = System.Drawing.Color.Transparent;
            this.EqualSignImage.Image = global::SymathWorld.Properties.Resources._660520;
            this.EqualSignImage.Location = new System.Drawing.Point(490, 247);
            this.EqualSignImage.Name = "EqualSignImage";
            this.EqualSignImage.Size = new System.Drawing.Size(59, 50);
            this.EqualSignImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EqualSignImage.TabIndex = 4;
            this.EqualSignImage.TabStop = false;
            // 
            // Answer_txt
            // 
            this.Answer_txt.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_txt.Location = new System.Drawing.Point(618, 213);
            this.Answer_txt.Name = "Answer_txt";
            this.Answer_txt.Size = new System.Drawing.Size(158, 114);
            this.Answer_txt.TabIndex = 5;
            // 
            // CheckAnswer_btn
            // 
            this.CheckAnswer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAnswer_btn.Location = new System.Drawing.Point(330, 349);
            this.CheckAnswer_btn.Name = "CheckAnswer_btn";
            this.CheckAnswer_btn.Size = new System.Drawing.Size(156, 35);
            this.CheckAnswer_btn.TabIndex = 6;
            this.CheckAnswer_btn.Text = "Check Answer";
            this.CheckAnswer_btn.UseVisualStyleBackColor = true;
            this.CheckAnswer_btn.Click += new System.EventHandler(this.CheckAnswer_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(643, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.Location = new System.Drawing.Point(728, 402);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(36, 25);
            this.Score_Label.TabIndex = 8;
            this.Score_Label.Text = "15";
            // 
            // GoBack_btn
            // 
            this.GoBack_btn.BackColor = System.Drawing.Color.Transparent;
            this.GoBack_btn.Image = global::SymathWorld.Properties.Resources.Left_Arrow_Icon_PNG_Pic;
            this.GoBack_btn.Location = new System.Drawing.Point(57, 31);
            this.GoBack_btn.Name = "GoBack_btn";
            this.GoBack_btn.Size = new System.Drawing.Size(63, 60);
            this.GoBack_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoBack_btn.TabIndex = 9;
            this.GoBack_btn.TabStop = false;
            this.GoBack_btn.Click += new System.EventHandler(this.GoBack_btn_Click);
            // 
            // Theme1_btn
            // 
            this.Theme1_btn.Location = new System.Drawing.Point(79, 413);
            this.Theme1_btn.Name = "Theme1_btn";
            this.Theme1_btn.Size = new System.Drawing.Size(41, 38);
            this.Theme1_btn.TabIndex = 10;
            this.Theme1_btn.Text = "1";
            this.Theme1_btn.UseVisualStyleBackColor = true;
            this.Theme1_btn.Click += new System.EventHandler(this.Theme1_btn_Click);
            // 
            // Theme2_btn
            // 
            this.Theme2_btn.Location = new System.Drawing.Point(151, 413);
            this.Theme2_btn.Name = "Theme2_btn";
            this.Theme2_btn.Size = new System.Drawing.Size(41, 38);
            this.Theme2_btn.TabIndex = 11;
            this.Theme2_btn.Text = "2";
            this.Theme2_btn.UseVisualStyleBackColor = true;
            this.Theme2_btn.Click += new System.EventHandler(this.Theme2_btn_Click);
            // 
            // Unit1Lesson1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SymathWorld.Properties.Resources.anime_landscape_classic_japanese_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.Theme2_btn);
            this.Controls.Add(this.Theme1_btn);
            this.Controls.Add(this.GoBack_btn);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckAnswer_btn);
            this.Controls.Add(this.Answer_txt);
            this.Controls.Add(this.EqualSignImage);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.Add_Label);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Unit1Lesson1";
            this.Text = "1.1: Adding Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.AddImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqualSignImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBack_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Add_Label;
        private System.Windows.Forms.PictureBox AddImage;
        private System.Windows.Forms.PictureBox EqualSignImage;
        private System.Windows.Forms.TextBox Answer_txt;
        private System.Windows.Forms.Button CheckAnswer_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.PictureBox GoBack_btn;
        private System.Windows.Forms.Button Theme1_btn;
        private System.Windows.Forms.Button Theme2_btn;
    }
}