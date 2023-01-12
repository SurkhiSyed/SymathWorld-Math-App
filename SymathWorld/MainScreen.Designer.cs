namespace SymathWorld
{
    partial class MainScreen
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
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.Begin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_Label.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.ForeColor = System.Drawing.Color.White;
            this.Welcome_Label.Location = new System.Drawing.Point(196, 56);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(377, 96);
            this.Welcome_Label.TabIndex = 0;
            this.Welcome_Label.Text = "Welcome!";
            // 
            // Begin_btn
            // 
            this.Begin_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin_btn.Location = new System.Drawing.Point(314, 172);
            this.Begin_btn.Name = "Begin_btn";
            this.Begin_btn.Size = new System.Drawing.Size(141, 46);
            this.Begin_btn.TabIndex = 1;
            this.Begin_btn.Text = "Begin";
            this.Begin_btn.UseVisualStyleBackColor = true;
            this.Begin_btn.Click += new System.EventHandler(this.Begin_btn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SymathWorld.Properties.Resources.HD_wallpaper_anime_shrine_japan_landscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.Begin_btn);
            this.Controls.Add(this.Welcome_Label);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Button Begin_btn;
    }
}

