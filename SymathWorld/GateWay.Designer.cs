namespace SymathWorld
{
    partial class GateWay
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
            this.GatesEnter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GatesEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // GatesEnter
            // 
            this.GatesEnter.Image = global::SymathWorld.Properties.Resources.gates;
            this.GatesEnter.Location = new System.Drawing.Point(153, 82);
            this.GatesEnter.Name = "GatesEnter";
            this.GatesEnter.Size = new System.Drawing.Size(495, 289);
            this.GatesEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GatesEnter.TabIndex = 0;
            this.GatesEnter.TabStop = false;
            // 
            // GateWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GatesEnter);
            this.Name = "GateWay";
            this.Text = "GateWay";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GatesEnter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GatesEnter;
    }
}