namespace Cyber_Punk_Trainer
{
    partial class Form1
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
            this.butPerk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butPerk
            // 
            this.butPerk.Location = new System.Drawing.Point(488, 235);
            this.butPerk.Name = "butPerk";
            this.butPerk.Size = new System.Drawing.Size(157, 49);
            this.butPerk.TabIndex = 0;
            this.butPerk.Text = "Perk Point +1";
            this.butPerk.UseVisualStyleBackColor = true;
            this.butPerk.Click += new System.EventHandler(this.butPerk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cyber_Punk_Trainer.Properties.Resources.thumb_1920_1062752;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1505, 824);
            this.Controls.Add(this.butPerk);
            this.Name = "Form1";
            this.Text = "Trainer Punk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPerk;
    }
}

