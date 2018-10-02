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

        private void Form1_Load(object sender, EventArgs e)
        {
            resetButt.Visible = false;
            errLabel.Visible = false;
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            userName = usernameInput.Text;
            easyButton.BackColor = Color.Lime;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            welcomeLabel.Text = "Welcome " + userName + "!";
            choseLabel.Text = "A true brave Hero! Go forth and conquer the easy path!";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            userName = usernameInput.Text;
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Orange;
            hardButton.BackColor = Color.Black;

            welcomeLabel.Text = "Welcome " + userName + "!";
            choseLabel.Text = "A true brave Hero! Go forth and conquer the medium path!";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            userName = usernameInput.Text;
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Red;

            welcomeLabel.Text = "Welcome " + userName + "!";
            choseLabel.Text = "A true brave Hero! Go forth and conquer the hard path!";
        }

        private void startButt_Click(object sender, EventArgs e)
        {
            easyButton.Visible = false;
            mediumButton.Visible = false;
            hardButton.Visible = false;
            difLabel.Visible = false;
            nameLabel.Visible = false;
            userLabel.Visible = false;
            usernameInput.Visible = false;
            startButt.Visible = false;
            resetButt.Visible = true;
            errLabel.Visible = true;

            errLabel.Text = "ERROR 404";
        }

        private void resetButt_Click(object sender, EventArgs e)
        {
            easyButton.Visible = true;
            mediumButton.Visible = true;
            hardButton.Visible = true;
            difLabel.Visible = true;
            nameLabel.Visible = true;
            userLabel.Visible = true;
            usernameInput.Visible = true;
            startButt.Visible = true;
            resetButt.Visible = false;
            errLabel.Visible = false;
        }
    }
}
