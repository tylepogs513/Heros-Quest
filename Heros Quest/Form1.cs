using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heros_Quest
{
    public partial class Form1 : Form
    {
        string userName;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            userName = usernameInput.Text;

            welcomeLabel.Text = "Welcome " + userName;
            choseLabel.Text = "A true brave Hero! Go forth and conquer the easy path!";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            userName = usernameInput.Text;

            welcomeLabel.Text = "Welcome " + userName;
            choseLabel.Text = "A true brave Hero! Go forth and conquer the medium path!";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            userName = usernameInput.Text;

            welcomeLabel.Text = "Welcome " + userName;
            choseLabel.Text = "A true brave Hero! Go forth and conquer the hard path!";
        }
    }
}
