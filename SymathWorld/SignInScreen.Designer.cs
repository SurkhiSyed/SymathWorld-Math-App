namespace SymathWorld
{
    partial class SignInScreen
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
            this.Username_Label = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Next_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.BackColor = System.Drawing.Color.Transparent;
            this.Username_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.White;
            this.Username_Label.Location = new System.Drawing.Point(92, 93);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(128, 32);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "Username";
            // 
            // Username_txt
            // 
            this.Username_txt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Username_txt.Location = new System.Drawing.Point(24, 140);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(261, 29);
            this.Username_txt.TabIndex = 1;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.White;
            this.Password_Label.Location = new System.Drawing.Point(92, 186);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(122, 32);
            this.Password_Label.TabIndex = 2;
            this.Password_Label.Text = "Password";
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(24, 230);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(261, 29);
            this.Password_txt.TabIndex = 3;
            // 
            // Next_btn
            // 
            this.Next_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.Location = new System.Drawing.Point(104, 293);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(104, 38);
            this.Next_btn.TabIndex = 4;
            this.Next_btn.Text = "Next";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SymathWorld.Properties.Resources.Mount_Fuji_In_Japan_iphone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Username_Label);
            this.Name = "SignInScreen";
            this.Text = "Sign-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Next_btn;
    }
}