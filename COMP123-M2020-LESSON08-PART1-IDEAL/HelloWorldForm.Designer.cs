namespace COMP123_M2020_LESSON08_PART1_IDEAL
{
    partial class HelloWorldForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLabel.Location = new System.Drawing.Point(-6, 201);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(638, 38);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hello, World!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.AutoSize = true;
            this.ClickMeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClickMeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClickMeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ClickMeButton.Location = new System.Drawing.Point(244, 242);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(136, 41);
            this.ClickMeButton.TabIndex = 2;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = false;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(209, 124);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 38);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(181, 83);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(262, 38);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Your Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.Load += new System.EventHandler(this.HelloWorldForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
    }
}

