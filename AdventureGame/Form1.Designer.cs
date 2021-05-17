
namespace AdventureGame
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(651, 104);
            this.outputLabel.TabIndex = 0;
            // 
            // option2Button
            // 
            this.option2Button.Image = global::AdventureGame.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.option2Button.Location = new System.Drawing.Point(12, 354);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(34, 33);
            this.option2Button.TabIndex = 2;
            this.option2Button.UseVisualStyleBackColor = true;
            // 
            // option3Button
            // 
            this.option3Button.Image = global::AdventureGame.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.option3Button.Location = new System.Drawing.Point(12, 393);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(34, 33);
            this.option3Button.TabIndex = 3;
            this.option3Button.UseVisualStyleBackColor = true;
            // 
            // option1Label
            // 
            this.option1Label.Location = new System.Drawing.Point(52, 315);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(539, 33);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "label1";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Label
            // 
            this.option2Label.Location = new System.Drawing.Point(52, 354);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(539, 33);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "label2";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Label
            // 
            this.option3Label.Location = new System.Drawing.Point(52, 393);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(539, 33);
            this.option3Label.TabIndex = 6;
            this.option3Label.Text = "label3";
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 113);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(651, 199);
            this.imageBox.TabIndex = 7;
            // 
            // option1Button
            // 
            this.option1Button.Image = global::AdventureGame.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.option1Button.Location = new System.Drawing.Point(12, 315);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(34, 33);
            this.option1Button.TabIndex = 1;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Label imageBox;
    }
}

