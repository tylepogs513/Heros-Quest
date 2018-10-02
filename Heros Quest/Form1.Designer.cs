namespace Heros_Quest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.difLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.choseLabel = new System.Windows.Forms.Label();
            this.startButt = new System.Windows.Forms.Button();
            this.resetButt = new System.Windows.Forms.Button();
            this.errLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(33, 259);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(116, 54);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "EASY";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(222, 259);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(116, 54);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "MEDIUM";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(407, 259);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(116, 54);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(132, 115);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(83, 16);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Username:";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(222, 112);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(201, 22);
            this.usernameInput.TabIndex = 4;
            // 
            // difLabel
            // 
            this.difLabel.AutoSize = true;
            this.difLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difLabel.ForeColor = System.Drawing.Color.White;
            this.difLabel.Location = new System.Drawing.Point(178, 186);
            this.difLabel.Name = "difLabel";
            this.difLabel.Size = new System.Drawing.Size(207, 24);
            this.difLabel.TabIndex = 5;
            this.difLabel.Text = "Select Your Difficulty.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(90, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(380, 48);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Hero\'s Quest";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(215, 346);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 24);
            this.welcomeLabel.TabIndex = 7;
            // 
            // choseLabel
            // 
            this.choseLabel.AutoSize = true;
            this.choseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choseLabel.ForeColor = System.Drawing.Color.White;
            this.choseLabel.Location = new System.Drawing.Point(29, 389);
            this.choseLabel.Name = "choseLabel";
            this.choseLabel.Size = new System.Drawing.Size(0, 24);
            this.choseLabel.TabIndex = 8;
            // 
            // startButt
            // 
            this.startButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.startButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.startButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButt.ForeColor = System.Drawing.Color.Blue;
            this.startButt.Location = new System.Drawing.Point(240, 412);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(97, 30);
            this.startButt.TabIndex = 9;
            this.startButt.Text = "Start";
            this.startButt.UseVisualStyleBackColor = true;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // resetButt
            // 
            this.resetButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.resetButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.resetButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButt.ForeColor = System.Drawing.Color.Blue;
            this.resetButt.Location = new System.Drawing.Point(231, 259);
            this.resetButt.Name = "resetButt";
            this.resetButt.Size = new System.Drawing.Size(97, 30);
            this.resetButt.TabIndex = 10;
            this.resetButt.Text = "Reset";
            this.resetButt.UseVisualStyleBackColor = true;
            this.resetButt.Click += new System.EventHandler(this.resetButt_Click);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("OCRA", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabel.ForeColor = System.Drawing.Color.White;
            this.errLabel.Location = new System.Drawing.Point(30, 23);
            this.errLabel.MinimumSize = new System.Drawing.Size(493, 400);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(493, 400);
            this.errLabel.TabIndex = 11;
            this.errLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.resetButt);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.startButt);
            this.Controls.Add(this.choseLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.difLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hero\'s Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label difLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label choseLabel;
        private System.Windows.Forms.Button startButt;
        private System.Windows.Forms.Button resetButt;
        private System.Windows.Forms.Label errLabel;
    }
}

