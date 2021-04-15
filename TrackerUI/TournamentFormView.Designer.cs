
namespace TrackerUI
{
    partial class TournamentFormView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.team1Name = new System.Windows.Forms.Label();
            this.Team2Label = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.team1ScoreValue = new System.Windows.Forms.TextBox();
            this.team2ScoreValue = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(132, 36);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Oswald", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.Location = new System.Drawing.Point(150, 13);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(74, 32);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.roundLabel.Location = new System.Drawing.Point(13, 73);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(50, 24);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(82, 70);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(121, 32);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(82, 137);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(116, 28);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 24;
            this.matchupListBox.Location = new System.Drawing.Point(12, 182);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(257, 314);
            this.matchupListBox.TabIndex = 5;
            // 
            // team1Name
            // 
            this.team1Name.AutoSize = true;
            this.team1Name.Font = new System.Drawing.Font("Oswald", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team1Name.Location = new System.Drawing.Point(417, 137);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(65, 28);
            this.team1Name.TabIndex = 6;
            this.team1Name.Text = " Team 1";
            // 
            // Team2Label
            // 
            this.Team2Label.AutoSize = true;
            this.Team2Label.Font = new System.Drawing.Font("Oswald", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team2Label.Location = new System.Drawing.Point(418, 309);
            this.Team2Label.Name = "Team2Label";
            this.Team2Label.Size = new System.Drawing.Size(64, 28);
            this.Team2Label.TabIndex = 7;
            this.Team2Label.Text = "Team 2";
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Location = new System.Drawing.Point(371, 182);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(45, 24);
            this.team1ScoreLabel.TabIndex = 8;
            this.team1ScoreLabel.Text = "Score";
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Location = new System.Drawing.Point(371, 368);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(45, 24);
            this.team2ScoreLabel.TabIndex = 9;
            this.team2ScoreLabel.Text = "Score";
            // 
            // team1ScoreValue
            // 
            this.team1ScoreValue.Location = new System.Drawing.Point(488, 179);
            this.team1ScoreValue.Name = "team1ScoreValue";
            this.team1ScoreValue.Size = new System.Drawing.Size(100, 31);
            this.team1ScoreValue.TabIndex = 10;
            // 
            // team2ScoreValue
            // 
            this.team2ScoreValue.Location = new System.Drawing.Point(488, 361);
            this.team2ScoreValue.Name = "team2ScoreValue";
            this.team2ScoreValue.Size = new System.Drawing.Size(100, 31);
            this.team2ScoreValue.TabIndex = 11;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(437, 246);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(33, 24);
            this.vsLabel.TabIndex = 12;
            this.vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(648, 230);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 57);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(879, 647);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.team2ScoreValue);
            this.Controls.Add(this.team1ScoreValue);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.Team2Label);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TournamentFormView";
            this.Text = "TournamentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label team1Name;
        private System.Windows.Forms.Label Team2Label;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.TextBox team1ScoreValue;
        private System.Windows.Forms.TextBox team2ScoreValue;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

