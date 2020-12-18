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
            this.butCommonItem = new System.Windows.Forms.Button();
            this.butUncommon = new System.Windows.Forms.Button();
            this.butRare = new System.Windows.Forms.Button();
            this.butRareUp = new System.Windows.Forms.Button();
            this.butEpicIt = new System.Windows.Forms.Button();
            this.butEpicUp = new System.Windows.Forms.Button();
            this.butLegItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butPerk
            // 
            this.butPerk.Location = new System.Drawing.Point(397, 185);
            this.butPerk.Name = "butPerk";
            this.butPerk.Size = new System.Drawing.Size(157, 49);
            this.butPerk.TabIndex = 0;
            this.butPerk.Text = "Perk Point +1";
            this.butPerk.UseVisualStyleBackColor = true;
            this.butPerk.Click += new System.EventHandler(this.butPerk_Click);
            // 
            // butCommonItem
            // 
            this.butCommonItem.Location = new System.Drawing.Point(397, 299);
            this.butCommonItem.Name = "butCommonItem";
            this.butCommonItem.Size = new System.Drawing.Size(157, 49);
            this.butCommonItem.TabIndex = 1;
            this.butCommonItem.Text = "Common Item Components +1k";
            this.butCommonItem.UseVisualStyleBackColor = true;
            this.butCommonItem.Click += new System.EventHandler(this.butCommonItem_Click);
            // 
            // butUncommon
            // 
            this.butUncommon.Location = new System.Drawing.Point(397, 412);
            this.butUncommon.Name = "butUncommon";
            this.butUncommon.Size = new System.Drawing.Size(157, 49);
            this.butUncommon.TabIndex = 2;
            this.butUncommon.Text = "Uncommon Item Components +1k";
            this.butUncommon.UseVisualStyleBackColor = true;
            this.butUncommon.Click += new System.EventHandler(this.butUncommon_Click);
            // 
            // butRare
            // 
            this.butRare.Location = new System.Drawing.Point(397, 527);
            this.butRare.Name = "butRare";
            this.butRare.Size = new System.Drawing.Size(157, 49);
            this.butRare.TabIndex = 3;
            this.butRare.Text = "Rare Item Components +1k";
            this.butRare.UseVisualStyleBackColor = true;
            this.butRare.Click += new System.EventHandler(this.butRare_Click);
            // 
            // butRareUp
            // 
            this.butRareUp.Location = new System.Drawing.Point(397, 639);
            this.butRareUp.Name = "butRareUp";
            this.butRareUp.Size = new System.Drawing.Size(157, 49);
            this.butRareUp.TabIndex = 4;
            this.butRareUp.Text = "Rare Upgrade Components +1k";
            this.butRareUp.UseVisualStyleBackColor = true;
            this.butRareUp.Click += new System.EventHandler(this.butRareUp_Click);
            // 
            // butEpicIt
            // 
            this.butEpicIt.Location = new System.Drawing.Point(637, 185);
            this.butEpicIt.Name = "butEpicIt";
            this.butEpicIt.Size = new System.Drawing.Size(157, 49);
            this.butEpicIt.TabIndex = 5;
            this.butEpicIt.Text = "Epic Item Components +1k";
            this.butEpicIt.UseVisualStyleBackColor = true;
            // 
            // butEpicUp
            // 
            this.butEpicUp.Location = new System.Drawing.Point(637, 299);
            this.butEpicUp.Name = "butEpicUp";
            this.butEpicUp.Size = new System.Drawing.Size(157, 49);
            this.butEpicUp.TabIndex = 6;
            this.butEpicUp.Text = "Epic Upgrade Components +1k";
            this.butEpicUp.UseVisualStyleBackColor = true;
            this.butEpicUp.Click += new System.EventHandler(this.butEpicUp_Click);
            // 
            // butLegItems
            // 
            this.butLegItems.Location = new System.Drawing.Point(637, 412);
            this.butLegItems.Name = "butLegItems";
            this.butLegItems.Size = new System.Drawing.Size(157, 49);
            this.butLegItems.TabIndex = 7;
            this.butLegItems.Text = "Legendary Item Components +1k";
            this.butLegItems.UseVisualStyleBackColor = true;
            this.butLegItems.Click += new System.EventHandler(this.butLegItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cyber_Punk_Trainer.Properties.Resources.thumb_1920_1062752;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1505, 824);
            this.Controls.Add(this.butLegItems);
            this.Controls.Add(this.butEpicUp);
            this.Controls.Add(this.butEpicIt);
            this.Controls.Add(this.butRareUp);
            this.Controls.Add(this.butRare);
            this.Controls.Add(this.butUncommon);
            this.Controls.Add(this.butCommonItem);
            this.Controls.Add(this.butPerk);
            this.Name = "Form1";
            this.Text = "Trainer Punk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPerk;
        private System.Windows.Forms.Button butCommonItem;
        private System.Windows.Forms.Button butUncommon;
        private System.Windows.Forms.Button butRare;
        private System.Windows.Forms.Button butRareUp;
        private System.Windows.Forms.Button butEpicIt;
        private System.Windows.Forms.Button butEpicUp;
        private System.Windows.Forms.Button butLegItems;
    }
}

