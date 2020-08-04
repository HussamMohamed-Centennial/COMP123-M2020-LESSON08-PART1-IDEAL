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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.GreetingsGroupBox = new System.Windows.Forms.GroupBox();
            this.GreetingCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userInfoGroupBox.SuspendLayout();
            this.GreetingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLabel.Location = new System.Drawing.Point(43, 21);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(187, 38);
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
            this.ClickMeButton.Location = new System.Drawing.Point(68, 53);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(136, 41);
            this.ClickMeButton.TabIndex = 2;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = false;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(44, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 38);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.LightGray;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(15, 34);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(262, 38);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Your Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_M2020_LESSON08_PART1_IDEAL.Properties.Resources.DefaultProfileImage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.AutoSize = true;
            this.userInfoGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.userInfoGroupBox.Controls.Add(this.NameLabel);
            this.userInfoGroupBox.Controls.Add(this.NameTextBox);
            this.userInfoGroupBox.Location = new System.Drawing.Point(211, 86);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Size = new System.Drawing.Size(296, 152);
            this.userInfoGroupBox.TabIndex = 4;
            this.userInfoGroupBox.TabStop = false;
            // 
            // GreetingsGroupBox
            // 
            this.GreetingsGroupBox.Controls.Add(this.WelcomeLabel);
            this.GreetingsGroupBox.Controls.Add(this.ClickMeButton);
            this.GreetingsGroupBox.Location = new System.Drawing.Point(211, 302);
            this.GreetingsGroupBox.Name = "GreetingsGroupBox";
            this.GreetingsGroupBox.Size = new System.Drawing.Size(272, 100);
            this.GreetingsGroupBox.TabIndex = 5;
            this.GreetingsGroupBox.TabStop = false;
            // 
            // GreetingCheckBox
            // 
            this.GreetingCheckBox.AutoSize = true;
            this.GreetingCheckBox.Checked = true;
            this.GreetingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GreetingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GreetingCheckBox.Location = new System.Drawing.Point(211, 244);
            this.GreetingCheckBox.Name = "GreetingCheckBox";
            this.GreetingCheckBox.Size = new System.Drawing.Size(120, 21);
            this.GreetingCheckBox.TabIndex = 6;
            this.GreetingCheckBox.Text = "Show Greeting";
            this.GreetingCheckBox.UseVisualStyleBackColor = true;
            this.GreetingCheckBox.CheckedChanged += new System.EventHandler(this.GreetingCheckBox_CheckedChanged);
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.GreetingCheckBox);
            this.Controls.Add(this.GreetingsGroupBox);
            this.Controls.Add(this.userInfoGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.Load += new System.EventHandler(this.HelloWorldForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            this.GreetingsGroupBox.ResumeLayout(false);
            this.GreetingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox userInfoGroupBox;
        private System.Windows.Forms.GroupBox GreetingsGroupBox;
        private System.Windows.Forms.CheckBox GreetingCheckBox;
    }
}

