
namespace TrackerUI
{
    partial class CreateTournament
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
            this.headerLabelCreate = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameInput = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.newTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeam = new System.Windows.Forms.Button();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerBtn = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTounamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabelCreate
            // 
            this.headerLabelCreate.AutoSize = true;
            this.headerLabelCreate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.headerLabelCreate.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabelCreate.Location = new System.Drawing.Point(34, 22);
            this.headerLabelCreate.Name = "headerLabelCreate";
            this.headerLabelCreate.Size = new System.Drawing.Size(199, 36);
            this.headerLabelCreate.TabIndex = 1;
            this.headerLabelCreate.Text = "Create Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tournamentNameLabel.Location = new System.Drawing.Point(34, 95);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(52, 21);
            this.tournamentNameLabel.TabIndex = 4;
            this.tournamentNameLabel.Text = "Name";
            // 
            // tournamentNameInput
            // 
            this.tournamentNameInput.Location = new System.Drawing.Point(133, 92);
            this.tournamentNameInput.Name = "tournamentNameInput";
            this.tournamentNameInput.Size = new System.Drawing.Size(100, 29);
            this.tournamentNameInput.TabIndex = 5;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.entryFeeLabel.Location = new System.Drawing.Point(34, 150);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(74, 21);
            this.entryFeeLabel.TabIndex = 6;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(145, 147);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 29);
            this.entryFeeValue.TabIndex = 7;
            this.entryFeeValue.Text = "0";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(145, 203);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(121, 29);
            this.selectTeamDropDown.TabIndex = 8;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.selectTeamLabel.Location = new System.Drawing.Point(34, 206);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(91, 21);
            this.selectTeamLabel.TabIndex = 9;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // newTeamLink
            // 
            this.newTeamLink.AutoSize = true;
            this.newTeamLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.newTeamLink.Location = new System.Drawing.Point(160, 179);
            this.newTeamLink.Name = "newTeamLink";
            this.newTeamLink.Size = new System.Drawing.Size(85, 21);
            this.newTeamLink.TabIndex = 10;
            this.newTeamLink.TabStop = true;
            this.newTeamLink.Text = "create new";
            // 
            // AddTeam
            // 
            this.AddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.AddTeam.Location = new System.Drawing.Point(34, 258);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(60, 55);
            this.AddTeam.TabIndex = 11;
            this.AddTeam.Text = "Add Team";
            this.AddTeam.UseVisualStyleBackColor = true;
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.createPrizeBtn.Location = new System.Drawing.Point(145, 258);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(75, 50);
            this.createPrizeBtn.TabIndex = 12;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 21;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(304, 62);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(225, 130);
            this.tournamentPlayersListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerBtn
            // 
            this.deleteSelectedPlayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteSelectedPlayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deleteSelectedPlayerBtn.Location = new System.Drawing.Point(566, 66);
            this.deleteSelectedPlayerBtn.Name = "deleteSelectedPlayerBtn";
            this.deleteSelectedPlayerBtn.Size = new System.Drawing.Size(112, 55);
            this.deleteSelectedPlayerBtn.TabIndex = 15;
            this.deleteSelectedPlayerBtn.Text = "Delete Selected";
            this.deleteSelectedPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeBtn
            // 
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.deleteSelectedPrizeBtn.Location = new System.Drawing.Point(566, 269);
            this.deleteSelectedPrizeBtn.Name = "deleteSelectedPrizeBtn";
            this.deleteSelectedPrizeBtn.Size = new System.Drawing.Size(112, 55);
            this.deleteSelectedPrizeBtn.TabIndex = 18;
            this.deleteSelectedPrizeBtn.Text = "Delete Selected";
            this.deleteSelectedPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(332, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 21;
            this.prizesListBox.Location = new System.Drawing.Point(304, 236);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(225, 130);
            this.prizesListBox.TabIndex = 16;
            // 
            // createTounamentBtn
            // 
            this.createTounamentBtn.Location = new System.Drawing.Point(49, 339);
            this.createTounamentBtn.Name = "createTounamentBtn";
            this.createTounamentBtn.Size = new System.Drawing.Size(171, 43);
            this.createTounamentBtn.TabIndex = 19;
            this.createTounamentBtn.Text = "Create Tournament";
            this.createTounamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(690, 424);
            this.Controls.Add(this.createTounamentBtn);
            this.Controls.Add(this.deleteSelectedPrizeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.AddTeam);
            this.Controls.Add(this.newTeamLink);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameInput);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabelCreate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CreateTournament";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabelCreate;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameInput;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel newTeamLink;
        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.Button createPrizeBtn;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteSelectedPlayerBtn;
        private System.Windows.Forms.Button deleteSelectedPrizeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTounamentBtn;
    }
}