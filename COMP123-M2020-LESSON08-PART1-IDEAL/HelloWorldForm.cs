using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON08_PART1_IDEAL
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method changes the text prop of the welcomeLable depending on its initial value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            WelcomeLabel.Text = (WelcomeLabel.Text == $" Hello, {NameTextBox.Text}") ? "Clicked!" : $" Hello, {NameTextBox.Text}";
        }


        /// <summary>
        /// The form load event is triggered once , when the form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            ClickMeButton.Enabled = false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ClickMeButton.Enabled = NameTextBox.Text.Length > 1;
        }
    }
}
