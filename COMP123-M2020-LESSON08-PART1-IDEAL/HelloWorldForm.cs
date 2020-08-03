﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            WelcomeLabel.Text =( WelcomeLabel.Text == "Hello, World!") ? "Clicked!" : "Hello, World!";
        }
    }
}
